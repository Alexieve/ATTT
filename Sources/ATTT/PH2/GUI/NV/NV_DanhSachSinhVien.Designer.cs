namespace PH2.GUI.NV
{
    partial class NV_DanhSachSinhVien
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
            dtgviewSinhVien = new DataGridView();
            gboxTimkiem = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            cbboxCT = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            tbDiaChi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbboxCN = new ComboBox();
            cbboxPhai = new ComboBox();
            tbDT = new TextBox();
            dtpkDOBTo = new DateTimePicker();
            dtpkDOBFrom = new DateTimePicker();
            tbHoTen = new TextBox();
            tbMaSV = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgviewSinhVien).BeginInit();
            gboxTimkiem.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgviewSinhVien
            // 
            dtgviewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewSinhVien.Location = new Point(12, 277);
            dtgviewSinhVien.Name = "dtgviewSinhVien";
            dtgviewSinhVien.RowHeadersWidth = 51;
            dtgviewSinhVien.Size = new Size(1291, 363);
            dtgviewSinhVien.TabIndex = 0;
            // 
            // gboxTimkiem
            // 
            gboxTimkiem.Controls.Add(label10);
            gboxTimkiem.Controls.Add(label9);
            gboxTimkiem.Controls.Add(label8);
            gboxTimkiem.Controls.Add(label7);
            gboxTimkiem.Controls.Add(label5);
            gboxTimkiem.Controls.Add(cbboxCT);
            gboxTimkiem.Controls.Add(label4);
            gboxTimkiem.Controls.Add(label3);
            gboxTimkiem.Controls.Add(tbDiaChi);
            gboxTimkiem.Controls.Add(label2);
            gboxTimkiem.Controls.Add(label1);
            gboxTimkiem.Controls.Add(cbboxCN);
            gboxTimkiem.Controls.Add(cbboxPhai);
            gboxTimkiem.Controls.Add(tbDT);
            gboxTimkiem.Controls.Add(dtpkDOBTo);
            gboxTimkiem.Controls.Add(dtpkDOBFrom);
            gboxTimkiem.Controls.Add(tbHoTen);
            gboxTimkiem.Controls.Add(tbMaSV);
            gboxTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTimkiem.Location = new Point(12, 98);
            gboxTimkiem.Name = "gboxTimkiem";
            gboxTimkiem.Size = new Size(1291, 173);
            gboxTimkiem.TabIndex = 1;
            gboxTimkiem.TabStop = false;
            gboxTimkiem.Text = "Tìm kiếm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(295, 102);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 25;
            label10.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(6, 102);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 24;
            label9.Text = "Điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(295, 31);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 23;
            label8.Text = "Họ tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 22;
            label7.Text = "Mã sinh viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(826, 128);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 21;
            label5.Text = "Chương trình:";
            // 
            // cbboxCT
            // 
            cbboxCT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbboxCT.FormattingEnabled = true;
            cbboxCT.Location = new Point(935, 124);
            cbboxCT.Name = "cbboxCT";
            cbboxCT.Size = new Size(110, 28);
            cbboxCT.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(1059, 128);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 19;
            label4.Text = "Chuyên ngành:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(652, 128);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 18;
            label3.Text = "Phái:";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Font = new Font("Segoe UI", 9F);
            tbDiaChi.Location = new Point(295, 125);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.PlaceholderText = "Nhập địa chỉ";
            tbDiaChi.Size = new Size(332, 27);
            tbDiaChi.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(1014, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 16;
            label2.Text = "đến:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(652, 57);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 15;
            label1.Text = "Ngày sinh từ:";
            // 
            // cbboxCN
            // 
            cbboxCN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbboxCN.FormattingEnabled = true;
            cbboxCN.Location = new Point(1175, 124);
            cbboxCN.Name = "cbboxCN";
            cbboxCN.Size = new Size(110, 28);
            cbboxCN.TabIndex = 14;
            // 
            // cbboxPhai
            // 
            cbboxPhai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbboxPhai.FormattingEnabled = true;
            cbboxPhai.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbboxPhai.Location = new Point(698, 124);
            cbboxPhai.Name = "cbboxPhai";
            cbboxPhai.Size = new Size(110, 28);
            cbboxPhai.TabIndex = 13;
            // 
            // tbDT
            // 
            tbDT.Font = new Font("Segoe UI", 9F);
            tbDT.Location = new Point(6, 125);
            tbDT.Name = "tbDT";
            tbDT.PlaceholderText = "Nhập điện thoại";
            tbDT.Size = new Size(257, 27);
            tbDT.TabIndex = 12;
            // 
            // dtpkDOBTo
            // 
            dtpkDOBTo.Font = new Font("Segoe UI", 9F);
            dtpkDOBTo.Location = new Point(1056, 54);
            dtpkDOBTo.Name = "dtpkDOBTo";
            dtpkDOBTo.Size = new Size(229, 27);
            dtpkDOBTo.TabIndex = 10;
            // 
            // dtpkDOBFrom
            // 
            dtpkDOBFrom.Font = new Font("Segoe UI", 9F);
            dtpkDOBFrom.Location = new Point(758, 54);
            dtpkDOBFrom.Name = "dtpkDOBFrom";
            dtpkDOBFrom.Size = new Size(229, 27);
            dtpkDOBFrom.TabIndex = 9;
            dtpkDOBFrom.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tbHoTen
            // 
            tbHoTen.Font = new Font("Segoe UI", 9F);
            tbHoTen.Location = new Point(295, 54);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.PlaceholderText = "Nhập họ tên";
            tbHoTen.Size = new Size(332, 27);
            tbHoTen.TabIndex = 4;
            // 
            // tbMaSV
            // 
            tbMaSV.Font = new Font("Segoe UI", 9F);
            tbMaSV.Location = new Point(6, 54);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.PlaceholderText = "Nhập mã sinh viên";
            tbMaSV.Size = new Size(257, 27);
            tbMaSV.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 98);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(475, 25);
            label6.Name = "label6";
            label6.Size = new Size(332, 38);
            label6.TabIndex = 0;
            label6.Text = "DANH SÁCH SINH VIÊN";
            // 
            // NV_DanhSachSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(panel1);
            Controls.Add(gboxTimkiem);
            Controls.Add(dtgviewSinhVien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_DanhSachSinhVien";
            Text = "NV_DanhSachSinhVien";
            ((System.ComponentModel.ISupportInitialize)dtgviewSinhVien).EndInit();
            gboxTimkiem.ResumeLayout(false);
            gboxTimkiem.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgviewSinhVien;
        private GroupBox gboxTimkiem;
        private TextBox tbHoTen;
        private TextBox tbMaSV;
        private Label label1;
        private ComboBox cbboxCN;
        private ComboBox cbboxPhai;
        private TextBox tbDT;
        private TextBox tbDiaChi;
        private DateTimePicker dtpkDOBTo;
        private DateTimePicker dtpkDOBFrom;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private ComboBox cbboxCT;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
    }
}