namespace PH2.GUI
{
    partial class SV_KHMO
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
            KHMOTable = new DataGridView();
            HKNamCbb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KHMOTable).BeginInit();
            SuspendLayout();
            // 
            // KHMOTable
            // 
            KHMOTable.AllowUserToAddRows = false;
            KHMOTable.AllowUserToDeleteRows = false;
            KHMOTable.AllowUserToOrderColumns = true;
            KHMOTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            KHMOTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            KHMOTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KHMOTable.Location = new Point(12, 52);
            KHMOTable.Name = "KHMOTable";
            KHMOTable.ReadOnly = true;
            KHMOTable.RowHeadersWidth = 51;
            KHMOTable.Size = new Size(1291, 588);
            KHMOTable.TabIndex = 3;
            // 
            // HKNamCbb
            // 
            HKNamCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            HKNamCbb.Font = new Font("Segoe UI", 12F);
            HKNamCbb.FormattingEnabled = true;
            HKNamCbb.Location = new Point(12, 10);
            HKNamCbb.Name = "HKNamCbb";
            HKNamCbb.Size = new Size(252, 36);
            HKNamCbb.TabIndex = 5;
            HKNamCbb.SelectedIndexChanged += Cbb_SelectedIndexChanged;
            // 
            // SV_KHMO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(HKNamCbb);
            Controls.Add(KHMOTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SV_KHMO";
            Text = "KHMOForm";
            ((System.ComponentModel.ISupportInitialize)KHMOTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView KHMOTable;
        private ComboBox HKNamCbb;
    }
}