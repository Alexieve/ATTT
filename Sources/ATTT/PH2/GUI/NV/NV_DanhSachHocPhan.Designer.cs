namespace PH2.GUI.NV
{
    partial class NV_DanhSachHocPhan
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
            label6 = new Label();
            panel1 = new Panel();
            tbTenHP = new TextBox();
            tbMaHP = new TextBox();
            gboxTimkiem = new GroupBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            tbSTTH = new TextBox();
            tbSTLT = new TextBox();
            tbSSVTD = new TextBox();
            tbSTC = new TextBox();
            tbMaDV = new TextBox();
            dtgviewHocPhan = new DataGridView();
            panel1.SuspendLayout();
            gboxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewHocPhan).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(477, 25);
            label6.Name = "label6";
            label6.Size = new Size(338, 38);
            label6.TabIndex = 0;
            label6.Text = "DANH SÁCH HỌC PHẦN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 99);
            panel1.TabIndex = 8;
            // 
            // tbTenHP
            // 
            tbTenHP.Font = new Font("Segoe UI", 9F);
            tbTenHP.Location = new Point(6, 125);
            tbTenHP.Name = "tbTenHP";
            tbTenHP.PlaceholderText = "Nhập tên học phần";
            tbTenHP.Size = new Size(600, 27);
            tbTenHP.TabIndex = 4;
            // 
            // tbMaHP
            // 
            tbMaHP.Font = new Font("Segoe UI", 9F);
            tbMaHP.Location = new Point(6, 54);
            tbMaHP.Name = "tbMaHP";
            tbMaHP.PlaceholderText = "Nhập mã học phần";
            tbMaHP.Size = new Size(260, 27);
            tbMaHP.TabIndex = 0;
            // 
            // gboxTimkiem
            // 
            gboxTimkiem.Controls.Add(label8);
            gboxTimkiem.Controls.Add(label5);
            gboxTimkiem.Controls.Add(label4);
            gboxTimkiem.Controls.Add(label3);
            gboxTimkiem.Controls.Add(label2);
            gboxTimkiem.Controls.Add(label1);
            gboxTimkiem.Controls.Add(label7);
            gboxTimkiem.Controls.Add(tbSTTH);
            gboxTimkiem.Controls.Add(tbSTLT);
            gboxTimkiem.Controls.Add(tbSSVTD);
            gboxTimkiem.Controls.Add(tbSTC);
            gboxTimkiem.Controls.Add(tbMaDV);
            gboxTimkiem.Controls.Add(tbTenHP);
            gboxTimkiem.Controls.Add(tbMaHP);
            gboxTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTimkiem.Location = new Point(12, 105);
            gboxTimkiem.Name = "gboxTimkiem";
            gboxTimkiem.Size = new Size(1291, 166);
            gboxTimkiem.TabIndex = 7;
            gboxTimkiem.TabStop = false;
            gboxTimkiem.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(1025, 102);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 35;
            label8.Text = "Số tiết thực hành";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(1025, 31);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 34;
            label5.Text = "Số sinh viên tối đa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(686, 102);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 33;
            label4.Text = "Số tiết lý thuyết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(686, 31);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 32;
            label3.Text = "Số tín chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 31;
            label2.Text = "Tên học phần";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(346, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 30;
            label1.Text = "Mã đơn vị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 29;
            label7.Text = "Mã học phần";
            // 
            // tbSTTH
            // 
            tbSTTH.Font = new Font("Segoe UI", 9F);
            tbSTTH.Location = new Point(1025, 125);
            tbSTTH.Name = "tbSTTH";
            tbSTTH.PlaceholderText = "Nhập mã số thiết thực hành";
            tbSTTH.Size = new Size(260, 27);
            tbSTTH.TabIndex = 28;
            // 
            // tbSTLT
            // 
            tbSTLT.Font = new Font("Segoe UI", 9F);
            tbSTLT.Location = new Point(686, 125);
            tbSTLT.Name = "tbSTLT";
            tbSTLT.PlaceholderText = "Nhập số tiết lý thuyết";
            tbSTLT.Size = new Size(260, 27);
            tbSTLT.TabIndex = 27;
            // 
            // tbSSVTD
            // 
            tbSSVTD.Font = new Font("Segoe UI", 9F);
            tbSSVTD.Location = new Point(1025, 54);
            tbSSVTD.Name = "tbSSVTD";
            tbSSVTD.PlaceholderText = "Nhập số sinh viên tối đa";
            tbSSVTD.Size = new Size(260, 27);
            tbSSVTD.TabIndex = 26;
            // 
            // tbSTC
            // 
            tbSTC.Font = new Font("Segoe UI", 9F);
            tbSTC.Location = new Point(686, 54);
            tbSTC.Name = "tbSTC";
            tbSTC.PlaceholderText = "Nhập số tín chỉ";
            tbSTC.Size = new Size(260, 27);
            tbSTC.TabIndex = 25;
            // 
            // tbMaDV
            // 
            tbMaDV.Font = new Font("Segoe UI", 9F);
            tbMaDV.Location = new Point(346, 54);
            tbMaDV.Name = "tbMaDV";
            tbMaDV.PlaceholderText = "Nhập mã đơn vị";
            tbMaDV.Size = new Size(260, 27);
            tbMaDV.TabIndex = 15;
            // 
            // dtgviewHocPhan
            // 
            dtgviewHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewHocPhan.Location = new Point(12, 277);
            dtgviewHocPhan.Name = "dtgviewHocPhan";
            dtgviewHocPhan.RowHeadersWidth = 51;
            dtgviewHocPhan.Size = new Size(1291, 363);
            dtgviewHocPhan.TabIndex = 6;
            // 
            // TRUONGKHOA_DanhSachDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(panel1);
            Controls.Add(gboxTimkiem);
            Controls.Add(dtgviewHocPhan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TRUONGKHOA_DanhSachDangKy";
            Text = "NV_DanhSachHocPhan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gboxTimkiem.ResumeLayout(false);
            gboxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewHocPhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private TextBox tbTenHP;
        private TextBox tbMaHP;
        private GroupBox gboxTimkiem;
        private DataGridView dtgviewHocPhan;
        private TextBox tbMaDV;
        private TextBox tbSTLT;
        private TextBox tbSSVTD;
        private TextBox tbSTC;
        private TextBox tbSTTH;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}