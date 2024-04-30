﻿namespace PH2.GUI
{
    partial class TRUONGDV_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRUONGDV_Home));
            sidePanel = new FlowLayoutPanel();
            tableSidePanel = new TableLayoutPanel();
            NhanSuBtn = new Button();
            DeTaiNCBtn = new Button();
            DangKyBtn = new Button();
            PhanCongBtn = new Button();
            panel1 = new Panel();
            NotifyBtn = new Button();
            nameLabel = new Label();
            TRUONGDVLabel = new Label();
            logoutBtn = new Button();
            DSSinhVienBtn = new Button();
            DSDonViBtn = new Button();
            DSHocPhanBtn = new Button();
            KHMOBtn = new Button();
            childFormPanel = new Panel();
            TaiLieuBtn = new Button();
            sidePanel.SuspendLayout();
            tableSidePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(tableSidePanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(269, 652);
            sidePanel.TabIndex = 0;
            // 
            // tableSidePanel
            // 
            tableSidePanel.ColumnCount = 1;
            tableSidePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableSidePanel.Controls.Add(TaiLieuBtn, 0, 7);
            tableSidePanel.Controls.Add(NhanSuBtn, 0, 8);
            tableSidePanel.Controls.Add(DangKyBtn, 0, 6);
            tableSidePanel.Controls.Add(PhanCongBtn, 0, 5);
            tableSidePanel.Controls.Add(panel1, 0, 0);
            tableSidePanel.Controls.Add(DSSinhVienBtn, 0, 1);
            tableSidePanel.Controls.Add(DSDonViBtn, 0, 2);
            tableSidePanel.Controls.Add(DSHocPhanBtn, 0, 3);
            tableSidePanel.Controls.Add(KHMOBtn, 0, 4);
            tableSidePanel.Controls.Add(DeTaiNCBtn, 0, 9);
            tableSidePanel.Location = new Point(0, 0);
            tableSidePanel.Margin = new Padding(0);
            tableSidePanel.Name = "tableSidePanel";
            tableSidePanel.RowCount = 10;
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableSidePanel.Size = new Size(269, 652);
            tableSidePanel.TabIndex = 0;
            // 
            // NhanSuBtn
            // 
            NhanSuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NhanSuBtn.FlatAppearance.BorderSize = 0;
            NhanSuBtn.FlatStyle = FlatStyle.Flat;
            NhanSuBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NhanSuBtn.ForeColor = Color.White;
            NhanSuBtn.Location = new Point(3, 532);
            NhanSuBtn.Name = "NhanSuBtn";
            NhanSuBtn.Size = new Size(263, 52);
            NhanSuBtn.TabIndex = 3;
            NhanSuBtn.Text = "Nhân Sự OLS";
            NhanSuBtn.UseVisualStyleBackColor = true;
            NhanSuBtn.Click += NhanSuBtn_Click;
            // 
            // DeTaiNCBtn
            // 
            DeTaiNCBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeTaiNCBtn.FlatAppearance.BorderSize = 0;
            DeTaiNCBtn.FlatStyle = FlatStyle.Flat;
            DeTaiNCBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeTaiNCBtn.ForeColor = Color.White;
            DeTaiNCBtn.Location = new Point(3, 590);
            DeTaiNCBtn.Name = "DeTaiNCBtn";
            DeTaiNCBtn.Size = new Size(263, 59);
            DeTaiNCBtn.TabIndex = 2;
            DeTaiNCBtn.Text = "Đề tài Nghiên Cứu";
            DeTaiNCBtn.UseVisualStyleBackColor = true;
            DeTaiNCBtn.Click += DeTaiNCBtn_Click;
            // 
            // DangKyBtn
            // 
            DangKyBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DangKyBtn.FlatAppearance.BorderSize = 0;
            DangKyBtn.FlatStyle = FlatStyle.Flat;
            DangKyBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DangKyBtn.ForeColor = Color.White;
            DangKyBtn.Location = new Point(3, 416);
            DangKyBtn.Name = "DangKyBtn";
            DangKyBtn.Size = new Size(263, 52);
            DangKyBtn.TabIndex = 1;
            DangKyBtn.Text = "Lớp Giảng Dạy";
            DangKyBtn.UseVisualStyleBackColor = true;
            DangKyBtn.Click += DangKyBtn_Click;
            // 
            // PhanCongBtn
            // 
            PhanCongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhanCongBtn.FlatAppearance.BorderSize = 0;
            PhanCongBtn.FlatStyle = FlatStyle.Flat;
            PhanCongBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PhanCongBtn.ForeColor = Color.White;
            PhanCongBtn.Location = new Point(3, 358);
            PhanCongBtn.Name = "PhanCongBtn";
            PhanCongBtn.Size = new Size(263, 52);
            PhanCongBtn.TabIndex = 1;
            PhanCongBtn.Text = "Bảng Phân Công";
            PhanCongBtn.UseVisualStyleBackColor = true;
            PhanCongBtn.Click += PhanCongBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(NotifyBtn);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(TRUONGDVLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 123);
            panel1.TabIndex = 1;
            // 
            // NotifyBtn
            // 
            NotifyBtn.Image = (Image)resources.GetObject("NotifyBtn.Image");
            NotifyBtn.Location = new Point(12, 9);
            NotifyBtn.Name = "NotifyBtn";
            NotifyBtn.Size = new Size(60, 60);
            NotifyBtn.TabIndex = 3;
            NotifyBtn.UseVisualStyleBackColor = true;
            NotifyBtn.Click += NotifyBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.BackColor = Color.Gray;
            nameLabel.Cursor = Cursors.Hand;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            nameLabel.Location = new Point(21, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(226, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Username";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Click += nameLabel_Click;
            // 
            // TRUONGDVLabel
            // 
            TRUONGDVLabel.Anchor = AnchorStyles.Top;
            TRUONGDVLabel.BackColor = Color.Gray;
            TRUONGDVLabel.Cursor = Cursors.AppStarting;
            TRUONGDVLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TRUONGDVLabel.ForeColor = SystemColors.ControlLightLight;
            TRUONGDVLabel.ImageAlign = ContentAlignment.MiddleLeft;
            TRUONGDVLabel.Location = new Point(25, 9);
            TRUONGDVLabel.Name = "TRUONGDVLabel";
            TRUONGDVLabel.Size = new Size(220, 20);
            TRUONGDVLabel.TabIndex = 1;
            TRUONGDVLabel.Text = "Trưởng Đơn Vị";
            TRUONGDVLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(87, 87);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // DSSinhVienBtn
            // 
            DSSinhVienBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DSSinhVienBtn.FlatAppearance.BorderSize = 0;
            DSSinhVienBtn.FlatStyle = FlatStyle.Flat;
            DSSinhVienBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DSSinhVienBtn.ForeColor = Color.White;
            DSSinhVienBtn.Location = new Point(3, 126);
            DSSinhVienBtn.Name = "DSSinhVienBtn";
            DSSinhVienBtn.Size = new Size(263, 52);
            DSSinhVienBtn.TabIndex = 0;
            DSSinhVienBtn.Text = "Danh Sách Sinh Viên";
            DSSinhVienBtn.UseVisualStyleBackColor = true;
            DSSinhVienBtn.Click += DSSinhVienBtn_Click;
            // 
            // DSDonViBtn
            // 
            DSDonViBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DSDonViBtn.FlatAppearance.BorderSize = 0;
            DSDonViBtn.FlatStyle = FlatStyle.Flat;
            DSDonViBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DSDonViBtn.ForeColor = Color.White;
            DSDonViBtn.Location = new Point(3, 184);
            DSDonViBtn.Name = "DSDonViBtn";
            DSDonViBtn.Size = new Size(263, 52);
            DSDonViBtn.TabIndex = 0;
            DSDonViBtn.Text = "Danh Sách Đơn Vị";
            DSDonViBtn.UseVisualStyleBackColor = true;
            DSDonViBtn.Click += DSDonViBtn_Click;
            // 
            // DSHocPhanBtn
            // 
            DSHocPhanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DSHocPhanBtn.FlatAppearance.BorderSize = 0;
            DSHocPhanBtn.FlatStyle = FlatStyle.Flat;
            DSHocPhanBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DSHocPhanBtn.ForeColor = Color.White;
            DSHocPhanBtn.Location = new Point(3, 242);
            DSHocPhanBtn.Name = "DSHocPhanBtn";
            DSHocPhanBtn.Size = new Size(263, 52);
            DSHocPhanBtn.TabIndex = 0;
            DSHocPhanBtn.Text = "Danh Sách Học Phần";
            DSHocPhanBtn.UseVisualStyleBackColor = true;
            DSHocPhanBtn.Click += DSHocPhanBtn_Click;
            // 
            // KHMOBtn
            // 
            KHMOBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KHMOBtn.FlatAppearance.BorderSize = 0;
            KHMOBtn.FlatStyle = FlatStyle.Flat;
            KHMOBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KHMOBtn.ForeColor = Color.White;
            KHMOBtn.Location = new Point(3, 300);
            KHMOBtn.Name = "KHMOBtn";
            KHMOBtn.Size = new Size(263, 52);
            KHMOBtn.TabIndex = 0;
            KHMOBtn.Text = "Kế Hoạch Mở";
            KHMOBtn.UseVisualStyleBackColor = true;
            KHMOBtn.Click += KHMOBtn_Click;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(269, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1315, 652);
            childFormPanel.TabIndex = 2;
            // 
            // TaiLieuBtn
            // 
            TaiLieuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TaiLieuBtn.FlatAppearance.BorderSize = 0;
            TaiLieuBtn.FlatStyle = FlatStyle.Flat;
            TaiLieuBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TaiLieuBtn.ForeColor = Color.White;
            TaiLieuBtn.Location = new Point(3, 474);
            TaiLieuBtn.Name = "TaiLieuBtn";
            TaiLieuBtn.Size = new Size(263, 52);
            TaiLieuBtn.TabIndex = 4;
            TaiLieuBtn.Text = "Tài liệu";
            TaiLieuBtn.UseVisualStyleBackColor = true;
            TaiLieuBtn.Click += TaiLieuBtn_Click;
            // 
            // TRUONGDV_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 652);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "TRUONGDV_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Đăng Ký Học Phần";
            sidePanel.ResumeLayout(false);
            tableSidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Button logoutBtn;
        private Button DSSinhVienBtn;
        private Button DSDonViBtn;
        private Button DSHocPhanBtn;
        private Button KHMOBtn;
        private Panel childFormPanel;
        private Label TRUONGDVLabel;
        private Label nameLabel;
        private TableLayoutPanel tableSidePanel;
        private Button NotifyBtn;
        private Button DangKyBtn;
        private Button PhanCongBtn;
        private Button DeTaiNCBtn;
        private Button NhanSuBtn;
        private Button TaiLieuBtn;
    }
}