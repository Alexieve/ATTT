namespace PH1
{
    partial class Audit_View
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
            SearchBox = new TextBox();
            SearchBtn = new Button();
            MainPanel = new Panel();
            AuditTb = new DataGridView();
            ActionPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AuditTb).BeginInit();
            SuspendLayout();
            // 
            // ActionPanel
            // 
            ActionPanel.Controls.Add(SearchBox);
            ActionPanel.Controls.Add(SearchBtn);
            ActionPanel.Font = new Font("Segoe UI", 12F);
            ActionPanel.Location = new Point(0, 4);
            ActionPanel.Margin = new Padding(0);
            ActionPanel.Name = "ActionPanel";
            ActionPanel.Size = new Size(1315, 56);
            ActionPanel.TabIndex = 9;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(12, 8);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Nhập Username hoặc Object name...";
            SearchBox.Size = new Size(361, 34);
            SearchBox.TabIndex = 7;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(0, 192, 0);
            SearchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(379, 7);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(128, 37);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Tìm kiếm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(AuditTb);
            MainPanel.Location = new Point(9, 60);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1297, 512);
            MainPanel.TabIndex = 8;
            // 
            // AuditTb
            // 
            AuditTb.AllowUserToAddRows = false;
            AuditTb.AllowUserToDeleteRows = false;
            AuditTb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            AuditTb.Size = new Size(1297, 512);
            AuditTb.TabIndex = 0;
            // 
            // Audit_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 577);
            Controls.Add(ActionPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Audit_View";
            Text = "Audit_View";
            ActionPanel.ResumeLayout(false);
            ActionPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AuditTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ActionPanel;
        private TextBox SearchBox;
        private Button SearchBtn;
        private Panel MainPanel;
        private DataGridView AuditTb;
    }
}