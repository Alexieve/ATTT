namespace PH1
{
    partial class Audit
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
            TabPanel = new TableLayoutPanel();
            AuditViewBtn = new Button();
            ObjectAuditBtn = new Button();
            UserAuditBtn = new Button();
            childFormPanel = new Panel();
            FGABtn = new Button();
            TabPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabPanel
            // 
            TabPanel.BackColor = SystemColors.GradientInactiveCaption;
            TabPanel.ColumnCount = 4;
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TabPanel.Controls.Add(FGABtn, 0, 0);
            TabPanel.Controls.Add(AuditViewBtn, 0, 0);
            TabPanel.Controls.Add(ObjectAuditBtn, 3, 0);
            TabPanel.Controls.Add(UserAuditBtn, 2, 0);
            TabPanel.Location = new Point(0, 0);
            TabPanel.Margin = new Padding(0);
            TabPanel.Name = "TabPanel";
            TabPanel.RowCount = 1;
            TabPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabPanel.Size = new Size(1315, 75);
            TabPanel.TabIndex = 0;
            // 
            // AuditViewBtn
            // 
            AuditViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AuditViewBtn.BackColor = SystemColors.GradientInactiveCaption;
            AuditViewBtn.FlatAppearance.BorderSize = 0;
            AuditViewBtn.FlatStyle = FlatStyle.Flat;
            AuditViewBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            AuditViewBtn.ForeColor = Color.Black;
            AuditViewBtn.Location = new Point(0, 0);
            AuditViewBtn.Margin = new Padding(0);
            AuditViewBtn.Name = "AuditViewBtn";
            AuditViewBtn.Size = new Size(328, 75);
            AuditViewBtn.TabIndex = 2;
            AuditViewBtn.Text = "Bảng Nhật Ký";
            AuditViewBtn.UseVisualStyleBackColor = false;
            AuditViewBtn.Click += AuditViewBtn_Click;
            // 
            // ObjectAuditBtn
            // 
            ObjectAuditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ObjectAuditBtn.BackColor = SystemColors.GradientInactiveCaption;
            ObjectAuditBtn.FlatAppearance.BorderSize = 0;
            ObjectAuditBtn.FlatStyle = FlatStyle.Flat;
            ObjectAuditBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ObjectAuditBtn.ForeColor = Color.Black;
            ObjectAuditBtn.Location = new Point(984, 0);
            ObjectAuditBtn.Margin = new Padding(0);
            ObjectAuditBtn.Name = "ObjectAuditBtn";
            ObjectAuditBtn.Size = new Size(331, 75);
            ObjectAuditBtn.TabIndex = 2;
            ObjectAuditBtn.Text = "Audit Theo Đối Tượng";
            ObjectAuditBtn.UseVisualStyleBackColor = false;
            ObjectAuditBtn.Click += ObjectAuditBtn_Click;
            // 
            // UserAuditBtn
            // 
            UserAuditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserAuditBtn.BackColor = SystemColors.GradientInactiveCaption;
            UserAuditBtn.FlatAppearance.BorderSize = 0;
            UserAuditBtn.FlatStyle = FlatStyle.Flat;
            UserAuditBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            UserAuditBtn.ForeColor = Color.Black;
            UserAuditBtn.Location = new Point(656, 0);
            UserAuditBtn.Margin = new Padding(0);
            UserAuditBtn.Name = "UserAuditBtn";
            UserAuditBtn.Size = new Size(328, 75);
            UserAuditBtn.TabIndex = 1;
            UserAuditBtn.Text = "Audit Theo Câu Lệnh";
            UserAuditBtn.UseVisualStyleBackColor = false;
            UserAuditBtn.Click += UserAuditBtn_Click;
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(0, 75);
            childFormPanel.Margin = new Padding(0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1315, 577);
            childFormPanel.TabIndex = 1;
            // 
            // FGABtn
            // 
            FGABtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FGABtn.BackColor = SystemColors.GradientInactiveCaption;
            FGABtn.FlatAppearance.BorderSize = 0;
            FGABtn.FlatStyle = FlatStyle.Flat;
            FGABtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            FGABtn.ForeColor = Color.Black;
            FGABtn.Location = new Point(328, 0);
            FGABtn.Margin = new Padding(0);
            FGABtn.Name = "FGABtn";
            FGABtn.Size = new Size(328, 75);
            FGABtn.TabIndex = 3;
            FGABtn.Text = "Bảng Nhật Ký FGA";
            FGABtn.UseVisualStyleBackColor = false;
            FGABtn.Click += FGABtn_Click;
            // 
            // Audit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(childFormPanel);
            Controls.Add(TabPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Audit";
            Text = "Audit";
            TabPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TabPanel;
        private Button ObjectAuditBtn;
        private Button UserAuditBtn;
        private Panel childFormPanel;
        private Button AuditViewBtn;
        private Button FGABtn;
    }
}