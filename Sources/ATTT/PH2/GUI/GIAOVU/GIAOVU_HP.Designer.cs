namespace PH2.GUI
{
    partial class GIAOVU_HP
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
            searchBox = new TextBox();
            searchBtn = new Button();
            button1 = new Button();
            button2 = new Button();
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
            HocPhanTable.SelectionChanged += HocPhanTable_SelectionChanged;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(11, 12);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Nhập Mã Học Phần/Mã Đơn Vị";
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(989, 12);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1181, 12);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 4;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GIAOVU_HP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchBtn);
            Controls.Add(searchBox);
            Controls.Add(HocPhanTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GIAOVU_HP";
            Text = "HocPhanForm";
            ((System.ComponentModel.ISupportInitialize)HocPhanTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HocPhanTable;
        private TextBox searchBox;
        private Button searchBtn;
        private Button button1;
        private Button button2;
    }
}