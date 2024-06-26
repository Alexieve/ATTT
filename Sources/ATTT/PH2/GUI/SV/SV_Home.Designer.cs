﻿namespace PH2.GUI
{
    partial class SV_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SV_Home));
            sidePanel = new FlowLayoutPanel();
            tableSidePanel = new TableLayoutPanel();
            DeTaiNCBtn = new Button();
            panel1 = new Panel();
            NotifyBtn = new Button();
            nameLabel = new Label();
            SVLabel = new Label();
            logoutBtn = new Button();
            HOCPHANPanel = new Button();
            KHMOPanel = new Button();
            DKHPPanel = new Button();
            KQHPPanel = new Button();
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
            tableSidePanel.Controls.Add(TaiLieuBtn, 0, 6);
            tableSidePanel.Controls.Add(DeTaiNCBtn, 0, 5);
            tableSidePanel.Controls.Add(panel1, 0, 0);
            tableSidePanel.Controls.Add(HOCPHANPanel, 0, 1);
            tableSidePanel.Controls.Add(KHMOPanel, 0, 2);
            tableSidePanel.Controls.Add(DKHPPanel, 0, 3);
            tableSidePanel.Controls.Add(KQHPPanel, 0, 4);
            tableSidePanel.Location = new Point(0, 0);
            tableSidePanel.Margin = new Padding(0);
            tableSidePanel.Name = "tableSidePanel";
            tableSidePanel.RowCount = 7;
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableSidePanel.Size = new Size(269, 652);
            tableSidePanel.TabIndex = 0;
            // 
            // DeTaiNCBtn
            // 
            DeTaiNCBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeTaiNCBtn.FlatAppearance.BorderSize = 0;
            DeTaiNCBtn.FlatStyle = FlatStyle.Flat;
            DeTaiNCBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeTaiNCBtn.ForeColor = Color.White;
            DeTaiNCBtn.Location = new Point(3, 482);
            DeTaiNCBtn.Name = "DeTaiNCBtn";
            DeTaiNCBtn.Size = new Size(263, 78);
            DeTaiNCBtn.TabIndex = 2;
            DeTaiNCBtn.Text = "Đề tài Nghiên cứu";
            DeTaiNCBtn.UseVisualStyleBackColor = true;
            DeTaiNCBtn.Click += DeTaiNCBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(NotifyBtn);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(SVLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 143);
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
            nameLabel.Location = new Point(21, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(226, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Username";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Click += nameLabel_Click;
            // 
            // SVLabel
            // 
            SVLabel.Anchor = AnchorStyles.Top;
            SVLabel.BackColor = Color.Gray;
            SVLabel.Cursor = Cursors.AppStarting;
            SVLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SVLabel.ForeColor = SystemColors.ControlLightLight;
            SVLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SVLabel.Location = new Point(25, 9);
            SVLabel.Name = "SVLabel";
            SVLabel.Size = new Size(220, 20);
            SVLabel.TabIndex = 1;
            SVLabel.Text = "Sinh Viên";
            SVLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(87, 104);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // HOCPHANPanel
            // 
            HOCPHANPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HOCPHANPanel.FlatAppearance.BorderSize = 0;
            HOCPHANPanel.FlatStyle = FlatStyle.Flat;
            HOCPHANPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HOCPHANPanel.ForeColor = Color.White;
            HOCPHANPanel.Location = new Point(3, 146);
            HOCPHANPanel.Name = "HOCPHANPanel";
            HOCPHANPanel.Size = new Size(263, 78);
            HOCPHANPanel.TabIndex = 0;
            HOCPHANPanel.Text = "Danh Sách Học Phần";
            HOCPHANPanel.UseVisualStyleBackColor = true;
            HOCPHANPanel.Click += HOCPHANPanel_Click;
            // 
            // KHMOPanel
            // 
            KHMOPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KHMOPanel.FlatAppearance.BorderSize = 0;
            KHMOPanel.FlatStyle = FlatStyle.Flat;
            KHMOPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KHMOPanel.ForeColor = Color.White;
            KHMOPanel.Location = new Point(3, 230);
            KHMOPanel.Name = "KHMOPanel";
            KHMOPanel.Size = new Size(263, 78);
            KHMOPanel.TabIndex = 0;
            KHMOPanel.Text = "Kế Hoạch Mở Môn";
            KHMOPanel.UseVisualStyleBackColor = true;
            KHMOPanel.Click += KHMOPanel_Click;
            // 
            // DKHPPanel
            // 
            DKHPPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DKHPPanel.FlatAppearance.BorderSize = 0;
            DKHPPanel.FlatStyle = FlatStyle.Flat;
            DKHPPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DKHPPanel.ForeColor = Color.White;
            DKHPPanel.Location = new Point(3, 314);
            DKHPPanel.Name = "DKHPPanel";
            DKHPPanel.Size = new Size(263, 78);
            DKHPPanel.TabIndex = 0;
            DKHPPanel.Text = "Đăng Ký Học Phần";
            DKHPPanel.UseVisualStyleBackColor = true;
            DKHPPanel.Click += DKHPPanel_Click;
            // 
            // KQHPPanel
            // 
            KQHPPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KQHPPanel.FlatAppearance.BorderSize = 0;
            KQHPPanel.FlatStyle = FlatStyle.Flat;
            KQHPPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KQHPPanel.ForeColor = Color.White;
            KQHPPanel.Location = new Point(3, 398);
            KQHPPanel.Name = "KQHPPanel";
            KQHPPanel.Size = new Size(263, 78);
            KQHPPanel.TabIndex = 0;
            KQHPPanel.Text = "Kết Quả Học Phần";
            KQHPPanel.UseVisualStyleBackColor = true;
            KQHPPanel.Click += KQHPPanel_Click;
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
            TaiLieuBtn.Location = new Point(3, 566);
            TaiLieuBtn.Name = "TaiLieuBtn";
            TaiLieuBtn.Size = new Size(263, 83);
            TaiLieuBtn.TabIndex = 3;
            TaiLieuBtn.Text = "Tài liệu";
            TaiLieuBtn.UseVisualStyleBackColor = true;
            TaiLieuBtn.Click += TaiLieuBtn_Click;
            // 
            // SV_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 652);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "SV_Home";
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
        private Button HOCPHANPanel;
        private Button KHMOPanel;
        private Button DKHPPanel;
        private Button KQHPPanel;
        private Panel childFormPanel;
        private Label SVLabel;
        private Label nameLabel;
        private TableLayoutPanel tableSidePanel;
        private Button NotifyBtn;
        private Button DeTaiNCBtn;
        private Button TaiLieuBtn;
    }
}