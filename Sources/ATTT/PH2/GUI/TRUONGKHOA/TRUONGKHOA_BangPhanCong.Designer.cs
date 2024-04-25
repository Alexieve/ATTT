namespace PH2.GUI.TRUONGKHOA
{
    partial class TRUONGKHOA_BangPhanCong
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
            panel1 = new Panel();
            label6 = new Label();
            dtgvPhanCong = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tbMADV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            tbHK = new TextBox();
            tbNAM = new TextBox();
            tbMACT = new TextBox();
            tbMAHP = new TextBox();
            tbMAGV = new TextBox();
            groupBox2 = new GroupBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhanCong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 98);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(512, 25);
            label6.Name = "label6";
            label6.Size = new Size(272, 38);
            label6.TabIndex = 0;
            label6.Text = "BẢNG PHÂN CÔNG";
            // 
            // dtgvPhanCong
            // 
            dtgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPhanCong.Location = new Point(12, 277);
            dtgvPhanCong.Name = "dtgvPhanCong";
            dtgvPhanCong.RowHeadersWidth = 51;
            dtgvPhanCong.Size = new Size(1291, 363);
            dtgvPhanCong.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbMADV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbHK);
            groupBox1.Controls.Add(tbNAM);
            groupBox1.Controls.Add(tbMACT);
            groupBox1.Controls.Add(tbMAHP);
            groupBox1.Controls.Add(tbMAGV);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 167);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(653, 102);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 36;
            label5.Text = "Mã đơn vị";
            // 
            // tbMADV
            // 
            tbMADV.Font = new Font("Segoe UI", 9F);
            tbMADV.Location = new Point(652, 125);
            tbMADV.Name = "tbMADV";
            tbMADV.PlaceholderText = "Nhập mã đơn vị";
            tbMADV.Size = new Size(274, 27);
            tbMADV.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(653, 32);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 34;
            label4.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(329, 102);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 33;
            label3.Text = "Mã chương trình";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(329, 32);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 32;
            label2.Text = "Học kỳ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 102);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã học phần";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 30;
            label7.Text = "Mã giáo viên";
            // 
            // tbHK
            // 
            tbHK.Font = new Font("Segoe UI", 9F);
            tbHK.Location = new Point(329, 55);
            tbHK.Name = "tbHK";
            tbHK.PlaceholderText = "Nhập học kỳ";
            tbHK.Size = new Size(274, 27);
            tbHK.TabIndex = 4;
            // 
            // tbNAM
            // 
            tbNAM.Font = new Font("Segoe UI", 9F);
            tbNAM.Location = new Point(652, 54);
            tbNAM.Name = "tbNAM";
            tbNAM.PlaceholderText = "Nhập năm";
            tbNAM.Size = new Size(274, 27);
            tbNAM.TabIndex = 3;
            // 
            // tbMACT
            // 
            tbMACT.Font = new Font("Segoe UI", 9F);
            tbMACT.Location = new Point(329, 125);
            tbMACT.Name = "tbMACT";
            tbMACT.PlaceholderText = "Nhập mã chương trình";
            tbMACT.Size = new Size(274, 27);
            tbMACT.TabIndex = 2;
            // 
            // tbMAHP
            // 
            tbMAHP.Font = new Font("Segoe UI", 9F);
            tbMAHP.Location = new Point(6, 125);
            tbMAHP.Name = "tbMAHP";
            tbMAHP.PlaceholderText = "Nhập mã học phần";
            tbMAHP.Size = new Size(274, 27);
            tbMAHP.TabIndex = 1;
            // 
            // tbMAGV
            // 
            tbMAGV.Font = new Font("Segoe UI", 9F);
            tbMAGV.Location = new Point(6, 54);
            tbMAGV.Name = "tbMAGV";
            tbMAGV.PlaceholderText = "Nhập mã giáo viên";
            tbMAGV.Size = new Size(274, 27);
            tbMAGV.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(945, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 167);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Cyan;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(252, 55);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(80, 80);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(139, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 80);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.Location = new Point(26, 54);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 80);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // TRUONGKHOA_BangPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgvPhanCong);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TRUONGKHOA_BangPhanCong";
            Text = "TRUONGKHOA_DanhSachPhanCong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhanCong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private DataGridView dtgvPhanCong;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private TextBox tbHK;
        private TextBox tbNAM;
        private TextBox tbMACT;
        private TextBox tbMAHP;
        private TextBox tbMAGV;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox tbMADV;
        private Button btnCapNhat;
    }
}