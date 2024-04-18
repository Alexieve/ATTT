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
            TenHP = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            MaCT = new DataGridViewTextBoxColumn();
            HK = new DataGridViewTextBoxColumn();
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
            DanhSachPC.Columns.AddRange(new DataGridViewColumn[] { TenHP, Nam, MaCT, HK });
            DanhSachPC.Location = new Point(0, 0);
            DanhSachPC.Name = "DanhSachPC";
            DanhSachPC.ReadOnly = true;
            DanhSachPC.RowHeadersWidth = 51;
            DanhSachPC.Size = new Size(1316, 653);
            DanhSachPC.TabIndex = 0;
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
            // MaCT
            // 
            MaCT.HeaderText = "Chương trình";
            MaCT.MinimumWidth = 6;
            MaCT.Name = "MaCT";
            MaCT.ReadOnly = true;
            // 
            // HK
            // 
            HK.HeaderText = "Học kì";
            HK.MinimumWidth = 6;
            HK.Name = "HK";
            HK.ReadOnly = true;
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
        private DataGridViewTextBoxColumn TenHP;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn MaCT;
        private DataGridViewTextBoxColumn HK;
    }
}