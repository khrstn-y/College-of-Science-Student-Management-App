using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;

namespace TIBOR_KHRISTINE_BSCS2B_Lab7A
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=student_db;Uid=root;Password=tunasandwich;";

        public Form1()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            RenderAnalyticsChart();
        }

        private void LoadStudentData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT student_id AS 'Student ID', full_name AS 'Full Name', course AS 'Course', gpa AS 'GPA' FROM students ORDER BY student_id ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DIAGNOSTIC ALERT: This will confirm if the database is actually reading rows
                    MessageBox.Show($"Database successfully read {dt.Rows.Count} student records!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dgvStudents != null)
                    {
                        dgvStudents.DataSource = null;
                        dgvStudents.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Load Error: " + ex.Message, "SQL Context Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RenderAnalyticsChart()
        {
            try
            {
                formsPlot1.Plot.Clear();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Fixed: Sorting by student_id here as well
                    string query = "SELECT full_name, gpa FROM students ORDER BY student_id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        var gpaList = new System.Collections.Generic.List<double>();
                        var positionList = new System.Collections.Generic.List<double>();
                        int index = 1;

                        while (reader.Read())
                        {
                            positionList.Add(index++);
                            gpaList.Add(Convert.ToDouble(reader["gpa"]));
                        }

                        if (gpaList.Count > 0)
                        {
                            var barPlot = formsPlot1.Plot.Add.Bars(positionList.ToArray(), gpaList.ToArray());
                            formsPlot1.Plot.Title($"Student Academic Performance ({gpaList.Count} Students)");
                            formsPlot1.Plot.XLabel("Student Index");
                            formsPlot1.Plot.YLabel("GPA");
                            formsPlot1.Plot.Axes.AutoScale();
                        }
                    }
                }
                formsPlot1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart Error: " + ex.Message, "Visual Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            LoadStudentData();
            RenderAnalyticsChart();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents?.DataSource == null || ((DataTable)dgvStudents.DataSource).Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export! Please make sure your database data loads into the grid first.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Student_Report.xlsx", CheckFileExists = false })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = (DataTable)dgvStudents.DataSource;
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Student Records");
                            worksheet.Cell(1, 1).InsertTable(dt);
                            worksheet.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);

                            MessageBox.Show("Excel report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel Error: " + ex.Message);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents?.DataSource == null || ((DataTable)dgvStudents.DataSource).Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export! Please make sure your database data loads into the grid first.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Document|*.pdf", FileName = "Student_Report.pdf", CheckFileExists = false })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string tempChartPath = Path.Combine(Path.GetTempPath(), "scottplot_temp.png");
                        formsPlot1.Plot.SavePng(tempChartPath, 700, 350);

                        DataTable dt = (DataTable)dgvStudents.DataSource;

                        Document.Create(container =>
                        {
                            container.Page(page =>
                            {
                                page.Margin(30);
                                page.Header().Text("Student Academic Performance Report")
                                    .FontSize(16).Bold().FontColor(QuestPDF.Helpers.Colors.Blue.Medium);

                                page.Content().Column(col =>
                                {
                                    col.Item().PaddingVertical(5).Text($"Generated Date: {DateTime.Now:MMMM dd, yyyy}");
                                    col.Item().PaddingVertical(10).Image(tempChartPath);
                                    col.Item().PaddingVertical(5).Text("Enrolled Student Directory").FontSize(12).Bold();

                                    col.Item().Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                        });

                                        table.Header(header =>
                                        {
                                            header.Cell().Text("Student ID").Bold();
                                            header.Cell().Text("Full Name").Bold();
                                            header.Cell().Text("Course").Bold();
                                            header.Cell().Text("GPA").Bold();
                                        });

                                        foreach (DataRow row in dt.Rows)
                                        {
                                            table.Cell().Text(row["Student ID"]?.ToString() ?? "");
                                            table.Cell().Text(row["Full Name"]?.ToString() ?? "");
                                            table.Cell().Text(row["Course"]?.ToString() ?? "");
                                            table.Cell().Text(row["GPA"]?.ToString() ?? "");
                                        }
                                    });
                                });

                                page.Footer().AlignCenter().Text(x =>
                                {
                                    x.CurrentPageNumber();
                                    x.Span(" / ");
                                    x.TotalPages();
                                });
                            });
                        }).GeneratePdf(sfd.FileName);

                        if (File.Exists(tempChartPath))
                            File.Delete(tempChartPath);

                        MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
        }
    }
}
