namespace PH2.GUI
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
            sidePanel = new FlowLayoutPanel();
            tableSidePanel = new TableLayoutPanel();
            panel1 = new Panel();
            nameLabel = new Label();
            SVLabel = new Label();
            logoutBtn = new Button();
            KQHPPanel = new Button();
            HOCPHANPanel = new Button();
            KHMOPanel = new Button();
            DKHPPanel = new Button();
            childFormPanel = new Panel();
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
            tableSidePanel.Controls.Add(panel1, 0, 0);
            tableSidePanel.Controls.Add(HOCPHANPanel, 0, 1);
            tableSidePanel.Controls.Add(KHMOPanel, 0, 2);
            tableSidePanel.Controls.Add(DKHPPanel, 0, 3);
            tableSidePanel.Controls.Add(KQHPPanel, 0, 4);
            tableSidePanel.Location = new Point(0, 0);
            tableSidePanel.Margin = new Padding(0);
            tableSidePanel.Name = "tableSidePanel";
            tableSidePanel.RowCount = 5;
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableSidePanel.Size = new Size(269, 652);
            tableSidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(SVLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 130);
            panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.BackColor = Color.Gray;
            nameLabel.Cursor = Cursors.Hand;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            nameLabel.Location = new Point(21, 50);
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
            logoutBtn.Location = new Point(87, 91);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // KQHPPanel
            // 
            KQHPPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KQHPPanel.FlatAppearance.BorderSize = 0;
            KQHPPanel.FlatStyle = FlatStyle.Flat;
            KQHPPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KQHPPanel.ForeColor = Color.White;
            KQHPPanel.Location = new Point(3, 523);
            KQHPPanel.Name = "KQHPPanel";
            KQHPPanel.Size = new Size(263, 126);
            KQHPPanel.TabIndex = 0;
            KQHPPanel.Text = "Kết Quả Học Phần";
            KQHPPanel.UseVisualStyleBackColor = true;
            KQHPPanel.Click += KQHPPanel_Click;
            // 
            // HOCPHANPanel
            // 
            HOCPHANPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HOCPHANPanel.FlatAppearance.BorderSize = 0;
            HOCPHANPanel.FlatStyle = FlatStyle.Flat;
            HOCPHANPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HOCPHANPanel.ForeColor = Color.White;
            HOCPHANPanel.Location = new Point(3, 133);
            HOCPHANPanel.Name = "HOCPHANPanel";
            HOCPHANPanel.Size = new Size(263, 124);
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
            KHMOPanel.Location = new Point(3, 263);
            KHMOPanel.Name = "KHMOPanel";
            KHMOPanel.Size = new Size(263, 124);
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
            DKHPPanel.Location = new Point(3, 393);
            DKHPPanel.Name = "DKHPPanel";
            DKHPPanel.Size = new Size(263, 124);
            DKHPPanel.TabIndex = 0;
            DKHPPanel.Text = "Đăng Ký Học Phần";
            DKHPPanel.UseVisualStyleBackColor = true;
            DKHPPanel.Click += DKHPPanel_Click;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(269, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1315, 652);
            childFormPanel.TabIndex = 2;
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
    }
}