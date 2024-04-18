namespace ATTT
{
    partial class HomeForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            AuditBtn = new Button();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            privManageBtn = new Button();
            listUserBtn = new Button();
            roleManageBtn = new Button();
            CheckPrivBtn = new Button();
            userManageBtn = new Button();
            childFormPanel = new Panel();
            sidePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(tableLayoutPanel1);
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(1582, 652);
            sidePanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(AuditBtn, 0, 6);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(privManageBtn, 0, 5);
            tableLayoutPanel1.Controls.Add(listUserBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(roleManageBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(CheckPrivBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(userManageBtn, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.Size = new Size(269, 652);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AuditBtn
            // 
            AuditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AuditBtn.FlatAppearance.BorderSize = 0;
            AuditBtn.FlatStyle = FlatStyle.Flat;
            AuditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AuditBtn.ForeColor = Color.White;
            AuditBtn.Location = new Point(3, 566);
            AuditBtn.Name = "AuditBtn";
            AuditBtn.Size = new Size(263, 83);
            AuditBtn.TabIndex = 0;
            AuditBtn.Text = "Ghi Nhật Ký Audit";
            AuditBtn.UseVisualStyleBackColor = true;
            AuditBtn.Click += AuditBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 143);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(22, 48);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(226, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(87, 96);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // privManageBtn
            // 
            privManageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privManageBtn.FlatAppearance.BorderSize = 0;
            privManageBtn.FlatStyle = FlatStyle.Flat;
            privManageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            privManageBtn.ForeColor = Color.White;
            privManageBtn.Location = new Point(3, 482);
            privManageBtn.Name = "privManageBtn";
            privManageBtn.Size = new Size(263, 78);
            privManageBtn.TabIndex = 0;
            privManageBtn.Text = "Quản lý quyền";
            privManageBtn.UseVisualStyleBackColor = true;
            privManageBtn.Click += privManageBtn_Click;
            // 
            // listUserBtn
            // 
            listUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUserBtn.FlatAppearance.BorderSize = 0;
            listUserBtn.FlatStyle = FlatStyle.Flat;
            listUserBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listUserBtn.ForeColor = Color.White;
            listUserBtn.Location = new Point(3, 146);
            listUserBtn.Name = "listUserBtn";
            listUserBtn.Size = new Size(263, 78);
            listUserBtn.TabIndex = 0;
            listUserBtn.Text = "Danh sách user";
            listUserBtn.UseVisualStyleBackColor = true;
            listUserBtn.Click += listUserBtn_Click;
            // 
            // roleManageBtn
            // 
            roleManageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleManageBtn.FlatAppearance.BorderSize = 0;
            roleManageBtn.FlatStyle = FlatStyle.Flat;
            roleManageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roleManageBtn.ForeColor = Color.White;
            roleManageBtn.Location = new Point(3, 398);
            roleManageBtn.Name = "roleManageBtn";
            roleManageBtn.Size = new Size(263, 78);
            roleManageBtn.TabIndex = 0;
            roleManageBtn.Text = "Quản lý role";
            roleManageBtn.UseVisualStyleBackColor = true;
            roleManageBtn.Click += roleManageBtn_Click;
            // 
            // CheckPrivBtn
            // 
            CheckPrivBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckPrivBtn.FlatAppearance.BorderSize = 0;
            CheckPrivBtn.FlatStyle = FlatStyle.Flat;
            CheckPrivBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckPrivBtn.ForeColor = Color.White;
            CheckPrivBtn.Location = new Point(3, 230);
            CheckPrivBtn.Name = "CheckPrivBtn";
            CheckPrivBtn.Size = new Size(263, 78);
            CheckPrivBtn.TabIndex = 0;
            CheckPrivBtn.Text = "Kiểm tra quyền";
            CheckPrivBtn.UseVisualStyleBackColor = true;
            CheckPrivBtn.Click += CheckPrivBtn_Click;
            // 
            // userManageBtn
            // 
            userManageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userManageBtn.FlatAppearance.BorderSize = 0;
            userManageBtn.FlatStyle = FlatStyle.Flat;
            userManageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userManageBtn.ForeColor = Color.White;
            userManageBtn.Location = new Point(3, 314);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(263, 78);
            userManageBtn.TabIndex = 0;
            userManageBtn.Text = "Quản lý user";
            userManageBtn.UseVisualStyleBackColor = true;
            userManageBtn.Click += userManageBtn_Click;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(269, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1315, 652);
            childFormPanel.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 652);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            Load += HomeForm_Load;
            sidePanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Button logoutBtn;
        private Label usernameLabel;
        private Button listUserBtn;
        private Button CheckPrivBtn;
        private Button userManageBtn;
        private Button roleManageBtn;
        private Button privManageBtn;
        private Button AuditBtn;
        private Panel childFormPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}