namespace PH2.GUI
{
    partial class SV_DSHocPhan
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
            HocPhanTable = new DataGridView();
            searchBox = new TextBox();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HocPhanTable).BeginInit();
            SuspendLayout();
            // 
            // HocPhanTable
            // 
            HocPhanTable.AllowUserToAddRows = false;
            HocPhanTable.AllowUserToDeleteRows = false;
            HocPhanTable.AllowUserToOrderColumns = true;
            HocPhanTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HocPhanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HocPhanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HocPhanTable.Location = new Point(12, 52);
            HocPhanTable.Name = "HocPhanTable";
            HocPhanTable.ReadOnly = true;
            HocPhanTable.RowHeadersWidth = 51;
            HocPhanTable.Size = new Size(1291, 588);
            HocPhanTable.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(11, 12);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Nhập Mã học phần hoặc Mã đơn vị..";
            searchBox.Size = new Size(623, 34);
            searchBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top;
            searchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(640, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(109, 34);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // SV_DSHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(searchBtn);
            Controls.Add(searchBox);
            Controls.Add(HocPhanTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SV_DSHocPhan";
            Text = "HocPhanForm";
            ((System.ComponentModel.ISupportInitialize)HocPhanTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HocPhanTable;
        private TextBox searchBox;
        private Button searchBtn;
    }
}