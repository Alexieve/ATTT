

namespace PH2.GUI
{
    partial class TaiLieu
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
            HocPhanTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HocPhanTable).BeginInit();
            SuspendLayout();
            // 
            // HocPhanTable
            // 
            HocPhanTable.AllowUserToAddRows = false;
            HocPhanTable.AllowUserToDeleteRows = false;
            HocPhanTable.AllowUserToOrderColumns = true;
            HocPhanTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HocPhanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HocPhanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HocPhanTable.Location = new Point(12, 52);
            HocPhanTable.Name = "HocPhanTable";
            HocPhanTable.ReadOnly = true;
            HocPhanTable.RowHeadersWidth = 51;
            HocPhanTable.Size = new Size(1291, 588);
            HocPhanTable.TabIndex = 0;
            // 
            // TaiLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(HocPhanTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiLieu";
            Text = "HocPhanForm";
            ((System.ComponentModel.ISupportInitialize)HocPhanTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HocPhanTable;
    }
}