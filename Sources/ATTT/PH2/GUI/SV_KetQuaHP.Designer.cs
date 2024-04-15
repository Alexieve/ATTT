namespace PH2.GUI
{
    partial class SV_KetQuaHP
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
            HKNamCbb = new ComboBox();
            DangKyTable = new DataGridView();
            panel1 = new Panel();
            DTBTitleLabel = new Label();
            DTBValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DangKyTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HKNamCbb
            // 
            HKNamCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            HKNamCbb.Font = new Font("Segoe UI", 12F);
            HKNamCbb.FormattingEnabled = true;
            HKNamCbb.Location = new Point(12, 11);
            HKNamCbb.Name = "HKNamCbb";
            HKNamCbb.Size = new Size(252, 36);
            HKNamCbb.TabIndex = 7;
            HKNamCbb.SelectedIndexChanged += HKNamCbb_SelectedIndexChanged;
            // 
            // DangKyTable
            // 
            DangKyTable.AllowUserToAddRows = false;
            DangKyTable.AllowUserToDeleteRows = false;
            DangKyTable.AllowUserToOrderColumns = true;
            DangKyTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DangKyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DangKyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DangKyTable.Location = new Point(12, 53);
            DangKyTable.Name = "DangKyTable";
            DangKyTable.ReadOnly = true;
            DangKyTable.RowHeadersWidth = 51;
            DangKyTable.Size = new Size(1291, 588);
            DangKyTable.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(DTBValueLabel);
            panel1.Controls.Add(DTBTitleLabel);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(1177, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 36);
            panel1.TabIndex = 8;
            // 
            // DTBTitleLabel
            // 
            DTBTitleLabel.AutoSize = true;
            DTBTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTBTitleLabel.ForeColor = SystemColors.ButtonHighlight;
            DTBTitleLabel.Location = new Point(3, 2);
            DTBTitleLabel.Name = "DTBTitleLabel";
            DTBTitleLabel.Size = new Size(63, 28);
            DTBTitleLabel.TabIndex = 0;
            DTBTitleLabel.Text = "ĐTB: ";
            // 
            // DTBValueLabel
            // 
            DTBValueLabel.AutoSize = true;
            DTBValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTBValueLabel.ForeColor = SystemColors.ButtonHighlight;
            DTBValueLabel.Location = new Point(61, 2);
            DTBValueLabel.Name = "DTBValueLabel";
            DTBValueLabel.Size = new Size(65, 28);
            DTBValueLabel.TabIndex = 1;
            DTBValueLabel.Text = "00.00";
            // 
            // SV_KetQuaHP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(panel1);
            Controls.Add(HKNamCbb);
            Controls.Add(DangKyTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SV_KetQuaHP";
            Text = "KQHPForm";
            ((System.ComponentModel.ISupportInitialize)DangKyTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox HKNamCbb;
        private DataGridView DangKyTable;
        private Panel panel1;
        private Label DTBValueLabel;
        private Label DTBTitleLabel;
    }
}