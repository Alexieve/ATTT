namespace PH1
{
    partial class Audit_Statement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ActionPanel = new Panel();
            NoAuditBtn = new Button();
            NoAuditLabel = new Label();
            AuditBtn = new Button();
            WhenCbb = new ComboBox();
            WhenLabel = new Label();
            UserCbb = new ComboBox();
            UserLabel = new Label();
            AuditOptionCbb = new ComboBox();
            AuditOptionLabel = new Label();
            MainPanel = new Panel();
            AuditTb = new DataGridView();
            ActionPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AuditTb).BeginInit();
            SuspendLayout();
            // 
            // ActionPanel
            // 
            ActionPanel.Controls.Add(NoAuditBtn);
            ActionPanel.Controls.Add(NoAuditLabel);
            ActionPanel.Controls.Add(AuditBtn);
            ActionPanel.Controls.Add(WhenCbb);
            ActionPanel.Controls.Add(WhenLabel);
            ActionPanel.Controls.Add(UserCbb);
            ActionPanel.Controls.Add(UserLabel);
            ActionPanel.Controls.Add(AuditOptionCbb);
            ActionPanel.Controls.Add(AuditOptionLabel);
            ActionPanel.Font = new Font("Segoe UI", 12F);
            ActionPanel.Location = new Point(0, 0);
            ActionPanel.Margin = new Padding(0);
            ActionPanel.Name = "ActionPanel";
            ActionPanel.Size = new Size(1315, 131);
            ActionPanel.TabIndex = 7;
            // 
            // NoAuditBtn
            // 
            NoAuditBtn.BackColor = Color.Red;
            NoAuditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoAuditBtn.Location = new Point(474, 80);
            NoAuditBtn.Name = "NoAuditBtn";
            NoAuditBtn.Size = new Size(128, 37);
            NoAuditBtn.TabIndex = 8;
            NoAuditBtn.Text = "Huỷ";
            NoAuditBtn.UseVisualStyleBackColor = false;
            NoAuditBtn.Click += NoAuditBtn_Click;
            // 
            // NoAuditLabel
            // 
            NoAuditLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NoAuditLabel.AutoSize = true;
            NoAuditLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoAuditLabel.Location = new Point(12, 84);
            NoAuditLabel.Name = "NoAuditLabel";
            NoAuditLabel.Size = new Size(456, 28);
            NoAuditLabel.TabIndex = 7;
            NoAuditLabel.Text = "Chọn dòng Audit muốn huỷ trong bảng và Huỷ";
            // 
            // AuditBtn
            // 
            AuditBtn.BackColor = Color.FromArgb(0, 192, 0);
            AuditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditBtn.Location = new Point(1175, 18);
            AuditBtn.Name = "AuditBtn";
            AuditBtn.Size = new Size(128, 37);
            AuditBtn.TabIndex = 6;
            AuditBtn.Text = "Xác nhận";
            AuditBtn.UseVisualStyleBackColor = false;
            AuditBtn.Click += AuditBtn_Click;
            // 
            // WhenCbb
            // 
            WhenCbb.DropDownHeight = 140;
            WhenCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            WhenCbb.FormattingEnabled = true;
            WhenCbb.IntegralHeight = false;
            WhenCbb.Location = new Point(931, 19);
            WhenCbb.Name = "WhenCbb";
            WhenCbb.Size = new Size(226, 36);
            WhenCbb.TabIndex = 5;
            // 
            // WhenLabel
            // 
            WhenLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WhenLabel.AutoSize = true;
            WhenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WhenLabel.Location = new Point(750, 22);
            WhenLabel.Name = "WhenLabel";
            WhenLabel.Size = new Size(175, 28);
            WhenLabel.TabIndex = 4;
            WhenLabel.Text = "Chọn trường hợp";
            // 
            // UserCbb
            // 
            UserCbb.DropDownHeight = 140;
            UserCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            UserCbb.FormattingEnabled = true;
            UserCbb.IntegralHeight = false;
            UserCbb.Location = new Point(518, 19);
            UserCbb.Name = "UserCbb";
            UserCbb.Size = new Size(226, 36);
            UserCbb.TabIndex = 3;
            // 
            // UserLabel
            // 
            UserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(404, 22);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(108, 28);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "Chọn User";
            // 
            // AuditOptionCbb
            // 
            AuditOptionCbb.DropDownHeight = 140;
            AuditOptionCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            AuditOptionCbb.FormattingEnabled = true;
            AuditOptionCbb.IntegralHeight = false;
            AuditOptionCbb.Location = new Point(172, 19);
            AuditOptionCbb.Name = "AuditOptionCbb";
            AuditOptionCbb.Size = new Size(226, 36);
            AuditOptionCbb.TabIndex = 1;
            // 
            // AuditOptionLabel
            // 
            AuditOptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AuditOptionLabel.AutoSize = true;
            AuditOptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditOptionLabel.Location = new Point(12, 22);
            AuditOptionLabel.Name = "AuditOptionLabel";
            AuditOptionLabel.Size = new Size(154, 28);
            AuditOptionLabel.TabIndex = 0;
            AuditOptionLabel.Text = "Chọn điều kiện";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(AuditTb);
            MainPanel.Location = new Point(9, 134);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1297, 434);
            MainPanel.TabIndex = 6;
            // 
            // AuditTb
            // 
            AuditTb.AllowUserToAddRows = false;
            AuditTb.AllowUserToDeleteRows = false;
            AuditTb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AuditTb.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AuditTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AuditTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuditTb.Dock = DockStyle.Fill;
            AuditTb.Location = new Point(0, 0);
            AuditTb.Name = "AuditTb";
            AuditTb.ReadOnly = true;
            AuditTb.RowHeadersWidth = 51;
            AuditTb.Size = new Size(1297, 434);
            AuditTb.TabIndex = 0;
            // 
            // Audit_Statement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 577);
            Controls.Add(ActionPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Audit_Statement";
            Text = "Audit_Statement";
            ActionPanel.ResumeLayout(false);
            ActionPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AuditTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ActionPanel;
        private Label AuditOptionLabel;
        private Panel MainPanel;
        private DataGridView AuditTb;
        private ComboBox AuditOptionCbb;
        private ComboBox WhenCbb;
        private Label WhenLabel;
        private ComboBox UserCbb;
        private Label UserLabel;
        private Button AuditBtn;
        private Button NoAuditBtn;
        private Label NoAuditLabel;
    }
}