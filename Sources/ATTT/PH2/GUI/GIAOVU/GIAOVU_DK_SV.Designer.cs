namespace PH2.GUI
{
    partial class GIAOVU_DK_SV
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            HuyBtn = new Button();
            HPDaDKTable = new DataGridView();
            label1 = new Label();
            DKBtn = new Button();
            HPChuaDKTable = new DataGridView();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HPDaDKTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HPChuaDKTable).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(HuyBtn);
            splitContainer1.Panel1.Controls.Add(HPDaDKTable);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(DKBtn);
            splitContainer1.Panel2.Controls.Add(HPChuaDKTable);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1315, 742);
            splitContainer1.SplitterDistance = 275;
            splitContainer1.TabIndex = 0;
            // 
            // HuyBtn
            // 
            HuyBtn.BackColor = Color.FromArgb(192, 0, 0);
            HuyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyBtn.ForeColor = SystemColors.ButtonHighlight;
            HuyBtn.Location = new Point(1183, 6);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(120, 41);
            HuyBtn.TabIndex = 3;
            HuyBtn.Text = "Huỷ";
            HuyBtn.UseVisualStyleBackColor = false;
            HuyBtn.Click += HuyBtn_Click;
            // 
            // HPDaDKTable
            // 
            HPDaDKTable.AllowUserToAddRows = false;
            HPDaDKTable.AllowUserToDeleteRows = false;
            HPDaDKTable.AllowUserToOrderColumns = true;
            HPDaDKTable.BackgroundColor = SystemColors.ButtonHighlight;
            HPDaDKTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            HPDaDKTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            HPDaDKTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HPDaDKTable.Location = new Point(12, 50);
            HPDaDKTable.Name = "HPDaDKTable";
            HPDaDKTable.ReadOnly = true;
            HPDaDKTable.RowHeadersWidth = 51;
            HPDaDKTable.Size = new Size(1291, 189);
            HPDaDKTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 0;
            label1.Text = "Học Phần Đã Đăng Ký";
            // 
            // DKBtn
            // 
            DKBtn.BackColor = Color.FromArgb(0, 192, 0);
            DKBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DKBtn.ForeColor = SystemColors.ButtonHighlight;
            DKBtn.Location = new Point(1183, 6);
            DKBtn.Name = "DKBtn";
            DKBtn.Size = new Size(120, 41);
            DKBtn.TabIndex = 2;
            DKBtn.Text = "Đăng ký";
            DKBtn.UseVisualStyleBackColor = false;
            DKBtn.Click += DKBtn_Click;
            // 
            // HPChuaDKTable
            // 
            HPChuaDKTable.AllowUserToAddRows = false;
            HPChuaDKTable.AllowUserToDeleteRows = false;
            HPChuaDKTable.AllowUserToOrderColumns = true;
            HPChuaDKTable.BackgroundColor = SystemColors.ButtonHighlight;
            HPChuaDKTable.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            HPChuaDKTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            HPChuaDKTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HPChuaDKTable.Location = new Point(10, 50);
            HPChuaDKTable.Name = "HPChuaDKTable";
            HPChuaDKTable.ReadOnly = true;
            HPChuaDKTable.RowHeadersWidth = 51;
            HPChuaDKTable.Size = new Size(1293, 344);
            HPChuaDKTable.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(358, 38);
            label2.TabIndex = 1;
            label2.Text = "Học Phần Có Thể Đăng Ký";
            // 
            // button3
            // 
            button3.Location = new Point(597, 411);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 34;
            button3.Text = "Đóng";
            button3.Click += button3_Click;
            // 
            // GIAOVU_DK_SV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 742);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GIAOVU_DK_SV";
            Text = "DangKyHPSV";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HPDaDKTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)HPChuaDKTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView HPDaDKTable;
        private Label label1;
        private DataGridView HPChuaDKTable;
        private Label label2;
        private Button HuyBtn;
        private Button DKBtn;
        private Button button3;
    }
}