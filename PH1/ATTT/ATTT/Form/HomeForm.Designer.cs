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
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            panel2 = new Panel();
            listUserPanel = new Button();
            panel3 = new Panel();
            CheckPrivPanel = new Button();
            panel4 = new Panel();
            userManagePanel = new Button();
            panel5 = new Panel();
            roleManagePanel = new Button();
            panel6 = new Panel();
            privManagePanel = new Button();
            panel7 = new Panel();
            button6 = new Button();
            childFormPanel = new Panel();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(panel3);
            sidePanel.Controls.Add(panel4);
            sidePanel.Controls.Add(panel5);
            sidePanel.Controls.Add(panel6);
            sidePanel.Controls.Add(panel7);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(269, 652);
            sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 116);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(22, 35);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(220, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(84, 69);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listUserPanel);
            panel2.Location = new Point(3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 82);
            panel2.TabIndex = 1;
            // 
            // listUserPanel
            // 
            listUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUserPanel.FlatAppearance.BorderSize = 0;
            listUserPanel.FlatStyle = FlatStyle.Flat;
            listUserPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listUserPanel.ForeColor = Color.White;
            listUserPanel.Location = new Point(-3, 13);
            listUserPanel.Name = "listUserPanel";
            listUserPanel.Size = new Size(263, 56);
            listUserPanel.TabIndex = 0;
            listUserPanel.Text = "Danh sách user";
            listUserPanel.UseVisualStyleBackColor = true;
            listUserPanel.Click += listUserPanel_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(CheckPrivPanel);
            panel3.Location = new Point(3, 213);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 82);
            panel3.TabIndex = 2;
            // 
            // CheckPrivPanel
            // 
            CheckPrivPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckPrivPanel.FlatAppearance.BorderSize = 0;
            CheckPrivPanel.FlatStyle = FlatStyle.Flat;
            CheckPrivPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckPrivPanel.ForeColor = Color.White;
            CheckPrivPanel.Location = new Point(-3, 13);
            CheckPrivPanel.Name = "CheckPrivPanel";
            CheckPrivPanel.Size = new Size(263, 56);
            CheckPrivPanel.TabIndex = 0;
            CheckPrivPanel.Text = "Kiểm tra quyền";
            CheckPrivPanel.UseVisualStyleBackColor = true;
            CheckPrivPanel.Click += CheckPrivPanel_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(userManagePanel);
            panel4.Location = new Point(3, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 82);
            panel4.TabIndex = 3;
            // 
            // userManagePanel
            // 
            userManagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userManagePanel.FlatAppearance.BorderSize = 0;
            userManagePanel.FlatStyle = FlatStyle.Flat;
            userManagePanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userManagePanel.ForeColor = Color.White;
            userManagePanel.Location = new Point(-3, 13);
            userManagePanel.Name = "userManagePanel";
            userManagePanel.Size = new Size(263, 56);
            userManagePanel.TabIndex = 0;
            userManagePanel.Text = "Quản lý user";
            userManagePanel.UseVisualStyleBackColor = true;
            userManagePanel.Click += userManagePanel_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(roleManagePanel);
            panel5.Location = new Point(3, 389);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 82);
            panel5.TabIndex = 3;
            // 
            // roleManagePanel
            // 
            roleManagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleManagePanel.FlatAppearance.BorderSize = 0;
            roleManagePanel.FlatStyle = FlatStyle.Flat;
            roleManagePanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roleManagePanel.ForeColor = Color.White;
            roleManagePanel.Location = new Point(0, 13);
            roleManagePanel.Name = "roleManagePanel";
            roleManagePanel.Size = new Size(260, 56);
            roleManagePanel.TabIndex = 0;
            roleManagePanel.Text = "Quản lý role";
            roleManagePanel.UseVisualStyleBackColor = true;
            roleManagePanel.Click += roleManagePanel_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(privManagePanel);
            panel6.Location = new Point(3, 477);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 82);
            panel6.TabIndex = 3;
            // 
            // privManagePanel
            // 
            privManagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privManagePanel.FlatAppearance.BorderSize = 0;
            privManagePanel.FlatStyle = FlatStyle.Flat;
            privManagePanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            privManagePanel.ForeColor = Color.White;
            privManagePanel.Location = new Point(0, 13);
            privManagePanel.Name = "privManagePanel";
            privManagePanel.Size = new Size(263, 56);
            privManagePanel.TabIndex = 0;
            privManagePanel.Text = "Quản lý quyền";
            privManagePanel.UseVisualStyleBackColor = true;
            privManagePanel.Click += privManagePanel_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 565);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 82);
            panel7.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-3, 13);
            button6.Name = "button6";
            button6.Size = new Size(266, 56);
            button6.TabIndex = 0;
            button6.Text = "Temporary";
            button6.UseVisualStyleBackColor = true;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(269, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(869, 652);
            childFormPanel.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 652);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            sidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Panel panel2;
        private Button logoutBtn;
        private Label usernameLabel;
        private Button listUserPanel;
        private Panel panel3;
        private Button CheckPrivPanel;
        private Panel panel4;
        private Button userManagePanel;
        private Panel panel5;
        private Button roleManagePanel;
        private Panel panel6;
        private Button privManagePanel;
        private Panel panel7;
        private Button button6;
        private Panel childFormPanel;
    }
}