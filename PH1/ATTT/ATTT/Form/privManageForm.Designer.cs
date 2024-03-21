namespace ATTT
{
    partial class privManageForm
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
            TopBarPanel = new FlowLayoutPanel();
            GrantPrivPanel = new Panel();
            GrantPrivButton = new Button();
            GrantPrivColPanel = new Panel();
            GrantPrivColButton = new Button();
            GrantRolePanel = new Panel();
            GrantRoleButton = new Button();
            childFormPanel = new Panel();
            TopBarPanel.SuspendLayout();
            GrantPrivPanel.SuspendLayout();
            GrantPrivColPanel.SuspendLayout();
            GrantRolePanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = Color.FromArgb(224, 224, 224);
            TopBarPanel.Controls.Add(GrantPrivPanel);
            TopBarPanel.Controls.Add(GrantPrivColPanel);
            TopBarPanel.Controls.Add(GrantRolePanel);
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(1313, 90);
            TopBarPanel.TabIndex = 0;
            // 
            // GrantPrivPanel
            // 
            GrantPrivPanel.Controls.Add(GrantPrivButton);
            GrantPrivPanel.Location = new Point(3, 3);
            GrantPrivPanel.Name = "GrantPrivPanel";
            GrantPrivPanel.Size = new Size(431, 90);
            GrantPrivPanel.TabIndex = 2;
            // 
            // GrantPrivButton
            // 
            GrantPrivButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantPrivButton.FlatAppearance.BorderSize = 0;
            GrantPrivButton.FlatStyle = FlatStyle.Flat;
            GrantPrivButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            GrantPrivButton.ForeColor = Color.Black;
            GrantPrivButton.Location = new Point(0, 0);
            GrantPrivButton.Name = "GrantPrivButton";
            GrantPrivButton.Size = new Size(431, 90);
            GrantPrivButton.TabIndex = 0;
            GrantPrivButton.Text = "Cấp / Thu hồi quyền user/role (mức bảng)";
            GrantPrivButton.UseVisualStyleBackColor = true;
            GrantPrivButton.Click += GrantPrivButton_Click;
            // 
            // GrantPrivColPanel
            // 
            GrantPrivColPanel.Controls.Add(GrantPrivColButton);
            GrantPrivColPanel.Location = new Point(440, 3);
            GrantPrivColPanel.Name = "GrantPrivColPanel";
            GrantPrivColPanel.Size = new Size(431, 90);
            GrantPrivColPanel.TabIndex = 2;
            // 
            // GrantPrivColButton
            // 
            GrantPrivColButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantPrivColButton.FlatAppearance.BorderSize = 0;
            GrantPrivColButton.FlatStyle = FlatStyle.Flat;
            GrantPrivColButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            GrantPrivColButton.ForeColor = Color.Black;
            GrantPrivColButton.Location = new Point(0, 0);
            GrantPrivColButton.Name = "GrantPrivColButton";
            GrantPrivColButton.Size = new Size(431, 90);
            GrantPrivColButton.TabIndex = 0;
            GrantPrivColButton.Text = "Cấp / Thu hồi quyền user/role (mức cột)";
            GrantPrivColButton.UseVisualStyleBackColor = true;
            GrantPrivColButton.Click += GrantPrivColButton_Click;
            // 
            // GrantRolePanel
            // 
            GrantRolePanel.Controls.Add(GrantRoleButton);
            GrantRolePanel.Location = new Point(877, 3);
            GrantRolePanel.Name = "GrantRolePanel";
            GrantRolePanel.Size = new Size(431, 90);
            GrantRolePanel.TabIndex = 3;
            // 
            // GrantRoleButton
            // 
            GrantRoleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantRoleButton.FlatAppearance.BorderSize = 0;
            GrantRoleButton.FlatStyle = FlatStyle.Flat;
            GrantRoleButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            GrantRoleButton.ForeColor = Color.Black;
            GrantRoleButton.Location = new Point(0, 0);
            GrantRoleButton.Name = "GrantRoleButton";
            GrantRoleButton.Size = new Size(431, 90);
            GrantRoleButton.TabIndex = 0;
            GrantRoleButton.Text = "Cấp / Thu hồi role của user";
            GrantRoleButton.UseVisualStyleBackColor = true;
            GrantRoleButton.Click += GrantRoleButton_Click;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(0, 96);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1313, 555);
            childFormPanel.TabIndex = 1;
            // 
            // privManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(childFormPanel);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "privManageForm";
            Text = "privManageForm";
            TopBarPanel.ResumeLayout(false);
            GrantPrivPanel.ResumeLayout(false);
            GrantPrivColPanel.ResumeLayout(false);
            GrantRolePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel TopBarPanel;
        private Panel GrantPrivPanel;
        private Button GrantPrivButton;
        private Panel GrantPrivColPanel;
        private Button GrantPrivColButton;
        private Button GrantRoleButton;
        private Panel GrantRolePanel;
        private Panel childFormPanel;
    }
}