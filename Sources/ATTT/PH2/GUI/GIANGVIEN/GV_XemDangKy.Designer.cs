namespace PH2.GUI.GIANGVIEN
{
    partial class GV_XemDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            MASV = new TextBox();
            MAHP = new TextBox();
            HK = new TextBox();
            NAM = new TextBox();
            MACT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SearchButton = new Button();
            label6 = new Label();
            MAGV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1316, 553);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // MASV
            // 
            MASV.Location = new Point(45, 48);
            MASV.Name = "MASV";
            MASV.Size = new Size(125, 27);
            MASV.TabIndex = 1;
            // 
            // MAHP
            // 
            MAHP.Location = new Point(359, 48);
            MAHP.Name = "MAHP";
            MAHP.Size = new Size(125, 27);
            MAHP.TabIndex = 2;
            // 
            // HK
            // 
            HK.Location = new Point(516, 48);
            HK.Name = "HK";
            HK.Size = new Size(125, 27);
            HK.TabIndex = 3;
            // 
            // NAM
            // 
            NAM.Location = new Point(673, 48);
            NAM.Name = "NAM";
            NAM.Size = new Size(125, 27);
            NAM.TabIndex = 4;
            // 
            // MACT
            // 
            MACT.Location = new Point(830, 48);
            MACT.Name = "MACT";
            MACT.Size = new Size(148, 27);
            MACT.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 6;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(359, 22);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 7;
            label2.Text = "Mã Học Phần";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(516, 22);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 8;
            label3.Text = "Học Kì";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(670, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 9;
            label4.Text = "Năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(828, 22);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 10;
            label5.Text = "Mã Chương Trình";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(0, 192, 0);
            SearchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            SearchButton.ForeColor = SystemColors.ButtonHighlight;
            SearchButton.Location = new Point(1057, 40);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(111, 41);
            SearchButton.TabIndex = 11;
            SearchButton.Text = "Tỉm kiếm";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(202, 22);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 13;
            label6.Text = "Mã Giáo Viên";
            // 
            // MAGV
            // 
            MAGV.Location = new Point(202, 48);
            MAGV.Name = "MAGV";
            MAGV.Size = new Size(125, 27);
            MAGV.TabIndex = 12;
            // 
            // GV_XemDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(label6);
            Controls.Add(MAGV);
            Controls.Add(SearchButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MACT);
            Controls.Add(NAM);
            Controls.Add(HK);
            Controls.Add(MAHP);
            Controls.Add(MASV);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GV_XemDangKy";
            Text = "GV_XemDangKycs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox MASV;
        private TextBox MAHP;
        private TextBox HK;
        private TextBox NAM;
        private TextBox MACT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SearchButton;
        private Label label6;
        private TextBox MAGV;
    }
}