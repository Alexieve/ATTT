namespace PH1
{
    partial class Audit_Object
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ActionPanel = new Panel();
            ObjTypeCbb = new ComboBox();
            ObjTypeLabel = new Label();
            NoAuditBtn = new Button();
            NoAuditLabel = new Label();
            AuditBtn = new Button();
            WhenCbb = new ComboBox();
            WhenLabel = new Label();
            ObjectCbb = new ComboBox();
            ObjectLabel = new Label();
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
            ActionPanel.Controls.Add(ObjTypeCbb);
            ActionPanel.Controls.Add(ObjTypeLabel);
            ActionPanel.Controls.Add(NoAuditBtn);
            ActionPanel.Controls.Add(NoAuditLabel);
            ActionPanel.Controls.Add(AuditBtn);
            ActionPanel.Controls.Add(WhenCbb);
            ActionPanel.Controls.Add(WhenLabel);
            ActionPanel.Controls.Add(ObjectCbb);
            ActionPanel.Controls.Add(ObjectLabel);
            ActionPanel.Controls.Add(AuditOptionCbb);
            ActionPanel.Controls.Add(AuditOptionLabel);
            ActionPanel.Font = new Font("Segoe UI", 12F);
            ActionPanel.Location = new Point(0, 0);
            ActionPanel.Margin = new Padding(0);
            ActionPanel.Name = "ActionPanel";
            ActionPanel.Size = new Size(1315, 131);
            ActionPanel.TabIndex = 7;
            // 
            // ObjTypeCbb
            // 
            ObjTypeCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjTypeCbb.FormattingEnabled = true;
            ObjTypeCbb.Location = new Point(193, 18);
            ObjTypeCbb.Name = "ObjTypeCbb";
            ObjTypeCbb.Size = new Size(243, 36);
            ObjTypeCbb.TabIndex = 10;
            ObjTypeCbb.SelectedIndexChanged += ObjTypeCbb_SelectedIndexChanged;
            // 
            // ObjTypeLabel
            // 
            ObjTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ObjTypeLabel.AutoSize = true;
            ObjTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ObjTypeLabel.Location = new Point(12, 22);
            ObjTypeLabel.Name = "ObjTypeLabel";
            ObjTypeLabel.Size = new Size(152, 28);
            ObjTypeLabel.TabIndex = 9;
            ObjTypeLabel.Text = "Loại đối tượng";
            // 
            // NoAuditBtn
            // 
            NoAuditBtn.BackColor = Color.Red;
            NoAuditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoAuditBtn.Location = new Point(1178, 82);
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
            NoAuditLabel.Location = new Point(647, 86);
            NoAuditLabel.Name = "NoAuditLabel";
            NoAuditLabel.Size = new Size(525, 28);
            NoAuditLabel.TabIndex = 7;
            NoAuditLabel.Text = "Chọn ô hoặc dòng Audit muốn huỷ trong bảng và Huỷ";
            // 
            // AuditBtn
            // 
            AuditBtn.BackColor = Color.FromArgb(0, 192, 0);
            AuditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditBtn.Location = new Point(428, 82);
            AuditBtn.Name = "AuditBtn";
            AuditBtn.Size = new Size(128, 37);
            AuditBtn.TabIndex = 6;
            AuditBtn.Text = "Xác nhận";
            AuditBtn.UseVisualStyleBackColor = false;
            AuditBtn.Click += AuditBtn_Click;
            // 
            // WhenCbb
            // 
            WhenCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            WhenCbb.FormattingEnabled = true;
            WhenCbb.Location = new Point(193, 83);
            WhenCbb.Name = "WhenCbb";
            WhenCbb.Size = new Size(226, 36);
            WhenCbb.TabIndex = 5;
            // 
            // WhenLabel
            // 
            WhenLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WhenLabel.AutoSize = true;
            WhenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WhenLabel.Location = new Point(12, 86);
            WhenLabel.Name = "WhenLabel";
            WhenLabel.Size = new Size(175, 28);
            WhenLabel.TabIndex = 4;
            WhenLabel.Text = "Chọn trường hợp";
            // 
            // ObjectCbb
            // 
            ObjectCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjectCbb.FormattingEnabled = true;
            ObjectCbb.Location = new Point(860, 19);
            ObjectCbb.Name = "ObjectCbb";
            ObjectCbb.Size = new Size(443, 36);
            ObjectCbb.TabIndex = 3;
            // 
            // ObjectLabel
            // 
            ObjectLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ObjectLabel.AutoSize = true;
            ObjectLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ObjectLabel.Location = new Point(726, 22);
            ObjectLabel.Name = "ObjectLabel";
            ObjectLabel.Size = new Size(128, 28);
            ObjectLabel.TabIndex = 2;
            ObjectLabel.Text = "Chọn Object";
            // 
            // AuditOptionCbb
            // 
            AuditOptionCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            AuditOptionCbb.FormattingEnabled = true;
            AuditOptionCbb.Location = new Point(616, 19);
            AuditOptionCbb.Name = "AuditOptionCbb";
            AuditOptionCbb.Size = new Size(104, 36);
            AuditOptionCbb.TabIndex = 1;
            // 
            // AuditOptionLabel
            // 
            AuditOptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AuditOptionLabel.AutoSize = true;
            AuditOptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditOptionLabel.Location = new Point(456, 21);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AuditTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AuditTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuditTb.Dock = DockStyle.Fill;
            AuditTb.Location = new Point(0, 0);
            AuditTb.Name = "AuditTb";
            AuditTb.ReadOnly = true;
            AuditTb.RowHeadersWidth = 51;
            AuditTb.Size = new Size(1297, 434);
            AuditTb.TabIndex = 0;
            // 
            // Audit_Object
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 577);
            Controls.Add(ActionPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Audit_Object";
            Text = "Audit_Object";
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
        private ComboBox ObjectCbb;
        private Label ObjectLabel;
        private Button AuditBtn;
        private Button NoAuditBtn;
        private Label NoAuditLabel;
        private Label ObjTypeLabel;
        private ComboBox ObjTypeCbb;
    }
}