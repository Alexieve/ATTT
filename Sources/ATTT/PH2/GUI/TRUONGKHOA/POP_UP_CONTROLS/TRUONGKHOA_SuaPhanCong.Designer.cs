namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    partial class TRUONGKHOA_SuaPhanCong
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
            btnChinhSua = new Button();
            groupBox1 = new GroupBox();
            label11 = new Label();
            tbCOSO = new TextBox();
            label9 = new Label();
            tbMADV = new TextBox();
            label10 = new Label();
            tbHOTEN = new TextBox();
            label8 = new Label();
            tbSDT = new TextBox();
            label6 = new Label();
            tbMAGV = new TextBox();
            dtgviewGiangVien = new DataGridView();
            gboxTimkiem = new GroupBox();
            label7 = new Label();
            tbMACT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNAM = new TextBox();
            tbHK = new TextBox();
            tbMAHP = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            tbCOSOht = new TextBox();
            tbMADVht = new TextBox();
            tbMAGVht = new TextBox();
            label14 = new Label();
            tbHOTENht = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewGiangVien).BeginInit();
            gboxTimkiem.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.Cyan;
            btnChinhSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChinhSua.Location = new Point(1195, 12);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(80, 80);
            btnChinhSua.TabIndex = 16;
            btnChinhSua.Text = "Cập nhật";
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbCOSO);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbMADV);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbHOTEN);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbMAGV);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(449, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 183);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm giảng viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(597, 134);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 31;
            label11.Text = "Cơ sở:";
            // 
            // tbCOSO
            // 
            tbCOSO.Font = new Font("Segoe UI", 9F);
            tbCOSO.Location = new Point(659, 131);
            tbCOSO.Name = "tbCOSO";
            tbCOSO.PlaceholderText = "Nhập cơ sở";
            tbCOSO.Size = new Size(165, 27);
            tbCOSO.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(322, 134);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 29;
            label9.Text = "Mã đơn vị:";
            // 
            // tbMADV
            // 
            tbMADV.Font = new Font("Segoe UI", 9F);
            tbMADV.Location = new Point(416, 131);
            tbMADV.Name = "tbMADV";
            tbMADV.PlaceholderText = "Nhập mã đơn vị";
            tbMADV.Size = new Size(165, 27);
            tbMADV.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(322, 45);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 27;
            label10.Text = "Họ tên giảng viên:";
            // 
            // tbHOTEN
            // 
            tbHOTEN.Font = new Font("Segoe UI", 9F);
            tbHOTEN.Location = new Point(463, 42);
            tbHOTEN.Name = "tbHOTEN";
            tbHOTEN.PlaceholderText = "Nhập họ tên giảng viên";
            tbHOTEN.Size = new Size(240, 27);
            tbHOTEN.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(26, 134);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 25;
            label8.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            tbSDT.Font = new Font("Segoe UI", 9F);
            tbSDT.Location = new Point(141, 131);
            tbSDT.Name = "tbSDT";
            tbSDT.PlaceholderText = "Nhập số điện thoại";
            tbSDT.Size = new Size(165, 27);
            tbSDT.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(26, 45);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã giảng viên";
            // 
            // tbMAGV
            // 
            tbMAGV.Font = new Font("Segoe UI", 9F);
            tbMAGV.Location = new Point(141, 42);
            tbMAGV.Name = "tbMAGV";
            tbMAGV.PlaceholderText = "Nhập mã giảng viên";
            tbMAGV.Size = new Size(165, 27);
            tbMAGV.TabIndex = 22;
            // 
            // dtgviewGiangVien
            // 
            dtgviewGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewGiangVien.Location = new Point(449, 225);
            dtgviewGiangVien.Name = "dtgviewGiangVien";
            dtgviewGiangVien.RowHeadersWidth = 51;
            dtgviewGiangVien.Size = new Size(836, 368);
            dtgviewGiangVien.TabIndex = 14;
            // 
            // gboxTimkiem
            // 
            gboxTimkiem.Controls.Add(label7);
            gboxTimkiem.Controls.Add(tbMACT);
            gboxTimkiem.Controls.Add(label3);
            gboxTimkiem.Controls.Add(label2);
            gboxTimkiem.Controls.Add(label1);
            gboxTimkiem.Controls.Add(tbNAM);
            gboxTimkiem.Controls.Add(tbHK);
            gboxTimkiem.Controls.Add(tbMAHP);
            gboxTimkiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTimkiem.ForeColor = Color.Black;
            gboxTimkiem.Location = new Point(12, 36);
            gboxTimkiem.Name = "gboxTimkiem";
            gboxTimkiem.Size = new Size(405, 274);
            gboxTimkiem.TabIndex = 17;
            gboxTimkiem.TabStop = false;
            gboxTimkiem.Text = "Thông tin kế hoạch mở hiện tại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(26, 225);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 19;
            label7.Text = "Mã chương trình:";
            // 
            // tbMACT
            // 
            tbMACT.Font = new Font("Segoe UI", 9F);
            tbMACT.Location = new Point(179, 222);
            tbMACT.Name = "tbMACT";
            tbMACT.PlaceholderText = "Nhập mã chương trình";
            tbMACT.ReadOnly = true;
            tbMACT.Size = new Size(195, 27);
            tbMACT.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 45);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "Học kỳ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 105);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "Năm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 165);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 13;
            label1.Text = "Mã học phần:";
            // 
            // tbNAM
            // 
            tbNAM.Font = new Font("Segoe UI", 9F);
            tbNAM.Location = new Point(179, 102);
            tbNAM.Name = "tbNAM";
            tbNAM.PlaceholderText = "Nhập năm";
            tbNAM.ReadOnly = true;
            tbNAM.Size = new Size(195, 27);
            tbNAM.TabIndex = 12;
            // 
            // tbHK
            // 
            tbHK.Font = new Font("Segoe UI", 9F);
            tbHK.Location = new Point(179, 42);
            tbHK.Name = "tbHK";
            tbHK.PlaceholderText = "Nhập học kỳ";
            tbHK.ReadOnly = true;
            tbHK.Size = new Size(195, 27);
            tbHK.TabIndex = 4;
            // 
            // tbMAHP
            // 
            tbMAHP.Font = new Font("Segoe UI", 9F);
            tbMAHP.Location = new Point(179, 162);
            tbMAHP.Name = "tbMAHP";
            tbMAHP.PlaceholderText = "Nhập mã học phần";
            tbMAHP.ReadOnly = true;
            tbMAHP.Size = new Size(195, 27);
            tbMAHP.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbCOSOht);
            groupBox2.Controls.Add(tbMADVht);
            groupBox2.Controls.Add(tbMAGVht);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(tbHOTENht);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(12, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 274);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin giảng viên cần đổi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(26, 225);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 33;
            label5.Text = "Cơ sở:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 165);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 35;
            label4.Text = "Mã đơn vị:";
            // 
            // tbCOSOht
            // 
            tbCOSOht.Font = new Font("Segoe UI", 9F);
            tbCOSOht.Location = new Point(179, 222);
            tbCOSOht.Name = "tbCOSOht";
            tbCOSOht.PlaceholderText = "Nhập cơ sở";
            tbCOSOht.ReadOnly = true;
            tbCOSOht.Size = new Size(195, 27);
            tbCOSOht.TabIndex = 32;
            // 
            // tbMADVht
            // 
            tbMADVht.Font = new Font("Segoe UI", 9F);
            tbMADVht.Location = new Point(179, 162);
            tbMADVht.Name = "tbMADVht";
            tbMADVht.PlaceholderText = "Nhập mã đơn vị";
            tbMADVht.ReadOnly = true;
            tbMADVht.Size = new Size(195, 27);
            tbMADVht.TabIndex = 34;
            // 
            // tbMAGVht
            // 
            tbMAGVht.Font = new Font("Segoe UI", 9F);
            tbMAGVht.Location = new Point(179, 42);
            tbMAGVht.Name = "tbMAGVht";
            tbMAGVht.PlaceholderText = "Nhập mã giảng viên";
            tbMAGVht.ReadOnly = true;
            tbMAGVht.Size = new Size(195, 27);
            tbMAGVht.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label14.Location = new Point(26, 105);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 33;
            label14.Text = "Họ tên:";
            // 
            // tbHOTENht
            // 
            tbHOTENht.Font = new Font("Segoe UI", 9F);
            tbHOTENht.Location = new Point(179, 102);
            tbHOTENht.Name = "tbHOTENht";
            tbHOTENht.PlaceholderText = "Nhập họ tên giảng viên";
            tbHOTENht.ReadOnly = true;
            tbHOTENht.Size = new Size(195, 27);
            tbHOTENht.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(26, 45);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 32;
            label12.Text = "Mã:";
            // 
            // TRUONGKHOA_SuaPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 605);
            Controls.Add(groupBox2);
            Controls.Add(gboxTimkiem);
            Controls.Add(btnChinhSua);
            Controls.Add(groupBox1);
            Controls.Add(dtgviewGiangVien);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TRUONGKHOA_SuaPhanCong";
            Text = "TRUONGKHOA_SuaPhanCong";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewGiangVien).EndInit();
            gboxTimkiem.ResumeLayout(false);
            gboxTimkiem.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChinhSua;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox tbCOSO;
        private Label label9;
        private TextBox tbMADV;
        private Label label10;
        private TextBox tbHOTEN;
        private Label label8;
        private TextBox tbSDT;
        private Label label6;
        private TextBox tbMAGV;
        private DataGridView dtgviewGiangVien;
        private GroupBox gboxTimkiem;
        private Label label7;
        private TextBox tbMACT;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbNAM;
        private TextBox tbHK;
        private TextBox tbMAHP;
        private GroupBox groupBox2;
        private TextBox tbMAGVht;
        private Label label14;
        private TextBox tbHOTENht;
        private Label label12;
        private Label label5;
        private Label label4;
        private TextBox tbCOSOht;
        private TextBox tbMADVht;
    }
}