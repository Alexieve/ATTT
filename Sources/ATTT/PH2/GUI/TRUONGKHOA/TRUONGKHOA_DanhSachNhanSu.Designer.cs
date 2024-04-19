namespace PH2.GUI.TRUONGKHOA
{
    partial class TRUONGKHOA_DanhSachNhanSu
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
            btnThem = new Button();
            groupBox2 = new GroupBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            label5 = new Label();
            tbMADV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dtgvNhanSu = new DataGridView();
            tbVAITRO = new TextBox();
            label6 = new Label();
            gbTimKiem = new GroupBox();
            dtpkDOBTo = new DateTimePicker();
            label11 = new Label();
            dtpkDOBFrom = new DateTimePicker();
            cbboxPHAI = new ComboBox();
            label10 = new Label();
            tbPHUCAP = new TextBox();
            label8 = new Label();
            tbMACS = new TextBox();
            label9 = new Label();
            tbSDT = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            tbHOTEN = new TextBox();
            tbMANV = new TextBox();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNhanSu).BeginInit();
            gbTimKiem.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(946, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 167);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Cyan;
            btnCapNhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(250, 54);
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
            btnXoa.Location = new Point(138, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 80);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(630, 102);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 36;
            label5.Text = "Mã đơn vị";
            // 
            // tbMADV
            // 
            tbMADV.Font = new Font("Segoe UI", 9F);
            tbMADV.Location = new Point(630, 125);
            tbMADV.Name = "tbMADV";
            tbMADV.PlaceholderText = "Nhập mã đơn vị";
            tbMADV.Size = new Size(136, 27);
            tbMADV.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(328, 31);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 34;
            label4.Text = "Ngày sinh từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(479, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 33;
            label3.Text = "Vai trò";
            // 
            // dtgvNhanSu
            // 
            dtgvNhanSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNhanSu.Location = new Point(12, 277);
            dtgvNhanSu.Name = "dtgvNhanSu";
            dtgvNhanSu.RowHeadersWidth = 51;
            dtgvNhanSu.Size = new Size(1291, 363);
            dtgvNhanSu.TabIndex = 8;
            // 
            // tbVAITRO
            // 
            tbVAITRO.Font = new Font("Segoe UI", 9F);
            tbVAITRO.Location = new Point(479, 125);
            tbVAITRO.Name = "tbVAITRO";
            tbVAITRO.PlaceholderText = "Nhập vai trò";
            tbVAITRO.Size = new Size(136, 27);
            tbVAITRO.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(491, 25);
            label6.Name = "label6";
            label6.Size = new Size(322, 38);
            label6.TabIndex = 0;
            label6.Text = "DANH SÁCH NHÂN SỰ";
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(dtpkDOBTo);
            gbTimKiem.Controls.Add(label11);
            gbTimKiem.Controls.Add(dtpkDOBFrom);
            gbTimKiem.Controls.Add(cbboxPHAI);
            gbTimKiem.Controls.Add(label10);
            gbTimKiem.Controls.Add(tbPHUCAP);
            gbTimKiem.Controls.Add(label8);
            gbTimKiem.Controls.Add(tbMACS);
            gbTimKiem.Controls.Add(label9);
            gbTimKiem.Controls.Add(tbSDT);
            gbTimKiem.Controls.Add(label5);
            gbTimKiem.Controls.Add(tbMADV);
            gbTimKiem.Controls.Add(label4);
            gbTimKiem.Controls.Add(label3);
            gbTimKiem.Controls.Add(label2);
            gbTimKiem.Controls.Add(label1);
            gbTimKiem.Controls.Add(label7);
            gbTimKiem.Controls.Add(tbVAITRO);
            gbTimKiem.Controls.Add(tbHOTEN);
            gbTimKiem.Controls.Add(tbMANV);
            gbTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTimKiem.Location = new Point(12, 104);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(936, 167);
            gbTimKiem.TabIndex = 9;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm kiếm";
            // 
            // dtpkDOBTo
            // 
            dtpkDOBTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkDOBTo.Location = new Point(560, 55);
            dtpkDOBTo.Name = "dtpkDOBTo";
            dtpkDOBTo.Size = new Size(207, 27);
            dtpkDOBTo.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(560, 31);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 45;
            label11.Text = "Đến";
            // 
            // dtpkDOBFrom
            // 
            dtpkDOBFrom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkDOBFrom.Location = new Point(328, 55);
            dtpkDOBFrom.Name = "dtpkDOBFrom";
            dtpkDOBFrom.Size = new Size(207, 27);
            dtpkDOBFrom.TabIndex = 44;
            dtpkDOBFrom.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // cbboxPHAI
            // 
            cbboxPHAI.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbboxPHAI.FormattingEnabled = true;
            cbboxPHAI.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbboxPHAI.Location = new Point(167, 54);
            cbboxPHAI.Name = "cbboxPHAI";
            cbboxPHAI.Size = new Size(136, 28);
            cbboxPHAI.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(326, 102);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 42;
            label10.Text = "Số điện thoại";
            // 
            // tbPHUCAP
            // 
            tbPHUCAP.Font = new Font("Segoe UI", 9F);
            tbPHUCAP.Location = new Point(792, 54);
            tbPHUCAP.Name = "tbPHUCAP";
            tbPHUCAP.PlaceholderText = "Nhập phụ cấp";
            tbPHUCAP.Size = new Size(136, 27);
            tbPHUCAP.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(794, 102);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 40;
            label8.Text = "Mã cơ sở";
            // 
            // tbMACS
            // 
            tbMACS.Font = new Font("Segoe UI", 9F);
            tbMACS.Location = new Point(791, 125);
            tbMACS.Name = "tbMACS";
            tbMACS.PlaceholderText = "Nhập mã cơ sở";
            tbMACS.Size = new Size(136, 27);
            tbMACS.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(792, 31);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 38;
            label9.Text = "Phụ cấp";
            // 
            // tbSDT
            // 
            tbSDT.Font = new Font("Segoe UI", 9F);
            tbSDT.Location = new Point(328, 125);
            tbSDT.Name = "tbSDT";
            tbSDT.PlaceholderText = "Nhập số điện thoại";
            tbSDT.Size = new Size(136, 27);
            tbSDT.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(167, 31);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 32;
            label2.Text = "Phái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 102);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 31;
            label1.Text = "Họ tên ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 30;
            label7.Text = "Mã nhân viên";
            // 
            // tbHOTEN
            // 
            tbHOTEN.Font = new Font("Segoe UI", 9F);
            tbHOTEN.Location = new Point(6, 125);
            tbHOTEN.Name = "tbHOTEN";
            tbHOTEN.PlaceholderText = "Nhập họ tên";
            tbHOTEN.Size = new Size(301, 27);
            tbHOTEN.TabIndex = 1;
            // 
            // tbMANV
            // 
            tbMANV.Font = new Font("Segoe UI", 9F);
            tbMANV.Location = new Point(6, 54);
            tbMANV.Name = "tbMANV";
            tbMANV.PlaceholderText = "Nhập mã nhân viên";
            tbMANV.Size = new Size(136, 27);
            tbMANV.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 98);
            panel1.TabIndex = 7;
            // 
            // TRUONGKHOA_DanhSachNhanSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(groupBox2);
            Controls.Add(dtgvNhanSu);
            Controls.Add(gbTimKiem);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TRUONGKHOA_DanhSachNhanSu";
            Text = "TRUONGKHOA_DanhSachNhanSu";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvNhanSu).EndInit();
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThem;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Label label5;
        private TextBox tbMADV;
        private Label label4;
        private Label label3;
        private DataGridView dtgvNhanSu;
        private TextBox tbVAITRO;
        private Label label6;
        private GroupBox gbTimKiem;
        private Panel panel1;
        private Button btnCapNhat;
        private Label label10;
        private TextBox tbPHUCAP;
        private Label label8;
        private TextBox tbMACS;
        private Label label9;
        private TextBox tbSDT;
        private DateTimePicker dtpkDOBFrom;
        private DateTimePicker dtpkDOBTo;
        private Label label11;
        private ComboBox cbboxPHAI;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox tbHOTEN;
        private TextBox tbMANV;
    }
}