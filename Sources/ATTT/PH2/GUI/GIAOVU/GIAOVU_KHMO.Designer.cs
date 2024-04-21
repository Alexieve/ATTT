

namespace PH2.GUI

{
    partial class GIAOVU_KHMO
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            KHMOTable = new DataGridView();
            HKNamCbb = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)KHMOTable).BeginInit();
            SuspendLayout();
            // 
            // KHMOTable
            // 
            KHMOTable.AllowUserToAddRows = false;
            KHMOTable.AllowUserToDeleteRows = false;
            KHMOTable.AllowUserToOrderColumns = true;
            KHMOTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            KHMOTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            KHMOTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KHMOTable.Location = new Point(12, 52);
            KHMOTable.Name = "KHMOTable";
            KHMOTable.ReadOnly = true;
            KHMOTable.RowHeadersWidth = 51;
            KHMOTable.Size = new Size(1291, 588);
            KHMOTable.TabIndex = 3;
            KHMOTable.SelectionChanged += KHMOTable_SelectionChanged;

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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(871, 10);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 6;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1143, 10);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 7;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GIAOVU_KHMO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(HKNamCbb);
            Controls.Add(KHMOTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GIAOVU_KHMO";
            Text = "KHMOForm";
            ((System.ComponentModel.ISupportInitialize)KHMOTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView KHMOTable;
        private ComboBox HKNamCbb;
        private Button button1;
        private Button button2;
    }
}