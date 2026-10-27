namespace TIBOR_KHRISTINE_BSCS2B_Lab7A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtCourse = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            btnLoadChart = new Button();
            btnExportExcel = new Button();
            btnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.FromArgb(70, 95, 130);
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtStudentId.ForeColor = Color.White;
            txtStudentId.Location = new Point(53, 202);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(180, 25);
            txtStudentId.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(70, 95, 130);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(281, 202);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(180, 25);
            txtFullName.TabIndex = 1;
            // 
            // txtCourse
            // 
            txtCourse.BackColor = Color.FromArgb(70, 95, 130);
            txtCourse.BorderStyle = BorderStyle.FixedSingle;
            txtCourse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtCourse.ForeColor = Color.White;
            txtCourse.Location = new Point(511, 202);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(180, 25);
            txtCourse.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(51, 102, 153);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(42, 278);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(164, 36);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Add Student (Create)";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(230, 235, 240);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(60, 64, 67);
            btnUpdate.Location = new Point(212, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(164, 36);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Selected (Update)";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(186, 73, 73);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(382, 278);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 36);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Selected (Delete)";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(552, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 36);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(210, 220, 235);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 102, 153);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 244, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.GridColor = Color.FromArgb(180, 195, 215);
            dgvStudents.Location = new Point(382, 320);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(334, 150);
            dgvStudents.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(70, 95, 130);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(53, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 16);
            textBox1.TabIndex = 8;
            textBox1.Text = "Student ID:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(70, 95, 130);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(281, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 16);
            textBox2.TabIndex = 9;
            textBox2.Text = "Full Name:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(70, 95, 130);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(511, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 16);
            textBox3.TabIndex = 10;
            textBox3.Text = "Course:";
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(-6, 320);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(382, 247);
            formsPlot1.TabIndex = 11;
            // 
            // btnLoadChart
            // 
            btnLoadChart.Location = new Point(382, 476);
            btnLoadChart.Name = "btnLoadChart";
            btnLoadChart.Size = new Size(136, 23);
            btnLoadChart.TabIndex = 12;
            btnLoadChart.Text = "Load Analytics Chart";
            btnLoadChart.UseVisualStyleBackColor = true;
            btnLoadChart.Click += btnLoadChart_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(382, 505);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(136, 23);
            btnExportExcel.TabIndex = 13;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(382, 534);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(136, 23);
            btnExportPDF.TabIndex = 14;
            btnExportPDF.Text = "Export to PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            ClientSize = new Size(834, 561);
            Controls.Add(btnExportPDF);
            Controls.Add(btnExportExcel);
            Controls.Add(btnLoadChart);
            Controls.Add(formsPlot1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtCourse);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "College of Science Student Management App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtCourse;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvStudents;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button btnLoadChart;
        private Button btnExportExcel;
        private Button btnExportPDF;
    }
}
