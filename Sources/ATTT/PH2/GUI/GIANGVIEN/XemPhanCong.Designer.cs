namespace PH2.GUI.GIANGVIEN
{
    partial class XemPhanCong
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
            DanhSachPC = new DataGridView();
            MAHP = new DataGridViewTextBoxColumn();
            TenHP = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            HK = new DataGridViewTextBoxColumn();
            MACT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DanhSachPC).BeginInit();
            SuspendLayout();
            // 
            // DanhSachPC
            // 
            DanhSachPC.AllowUserToAddRows = false;
            DanhSachPC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DanhSachPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DanhSachPC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachPC.Columns.AddRange(new DataGridViewColumn[] { MAHP, TenHP, Nam, HK, MACT });
            DanhSachPC.Location = new Point(0, 0);
            DanhSachPC.Name = "DanhSachPC";
            DanhSachPC.ReadOnly = true;
            DanhSachPC.RowHeadersWidth = 51;
            DanhSachPC.Size = new Size(1316, 653);
            DanhSachPC.TabIndex = 0;
            // 
            // MAHP
            // 
            MAHP.HeaderText = "Mã học phần";
            MAHP.MinimumWidth = 6;
            MAHP.Name = "MAHP";
            MAHP.ReadOnly = true;
            // 
            // TenHP
            // 
            TenHP.HeaderText = "Tên học phần";
            TenHP.MinimumWidth = 6;
            TenHP.Name = "TenHP";
            TenHP.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // HK
            // 
            HK.HeaderText = "Học kì";
            HK.MinimumWidth = 6;
            HK.Name = "HK";
            HK.ReadOnly = true;
            // 
            // MACT
            // 
            MACT.HeaderText = "Chương trình";
            MACT.MinimumWidth = 6;
            MACT.Name = "MACT";
            MACT.ReadOnly = true;
            // 
            // XemPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(DanhSachPC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "XemPhanCong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DanhSachPC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DanhSachPC;
        private DataGridViewTextBoxColumn MAHP;
        private DataGridViewTextBoxColumn TenHP;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn HK;
        private DataGridViewTextBoxColumn MACT;
    }
}