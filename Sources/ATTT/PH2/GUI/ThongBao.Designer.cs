namespace PH2.GUI
{
    partial class ThongBao
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
            ParentPanel = new Panel();
            ThongBaoTB = new DataGridView();
            ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThongBaoTB).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(ThongBaoTB);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1315, 652);
            ParentPanel.TabIndex = 0;
            // 
            // ThongBaoTB
            // 
            ThongBaoTB.AllowUserToAddRows = false;
            ThongBaoTB.AllowUserToDeleteRows = false;
            ThongBaoTB.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ThongBaoTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ThongBaoTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ThongBaoTB.Dock = DockStyle.Fill;
            ThongBaoTB.Location = new Point(0, 0);
            ThongBaoTB.Name = "ThongBaoTB";
            ThongBaoTB.ReadOnly = true;
            ThongBaoTB.RowHeadersWidth = 51;
            ThongBaoTB.Size = new Size(1315, 652);
            ThongBaoTB.TabIndex = 0;
            // 
            // ThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongBao";
            Text = "ThongBao";
            ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ThongBaoTB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private DataGridView ThongBaoTB;
    }
}