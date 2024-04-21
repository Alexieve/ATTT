namespace PH2.GUI.NV
{
    partial class NV_DanhSachKHMO
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
            tbNAM = new TextBox();
            tbHK = new TextBox();
            tbMAHP = new TextBox();
            gboxTimkiem = new GroupBox();
            label5 = new Label();
            tbTENHP = new TextBox();
            label7 = new Label();
            tbSOTC = new TextBox();
            label4 = new Label();
            tbMADV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgviewKHMO = new DataGridView();
            panel1.SuspendLayout();
            gboxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewKHMO).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 99);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 25);
            label6.Name = "label6";
            label6.Size = new Size(389, 38);
            label6.TabIndex = 0;
            label6.Text = "DANH SÁCH KẾ HOẠCH MỞ";
            // 
            // tbNAM
            // 
            tbNAM.Font = new Font("Segoe UI", 9F);
            tbNAM.Location = new Point(475, 54);
            tbNAM.Name = "tbNAM";
            tbNAM.PlaceholderText = "Nhập năm";
            tbNAM.Size = new Size(344, 27);
            tbNAM.TabIndex = 12;
            // 
            // tbHK
            // 
            tbHK.Font = new Font("Segoe UI", 9F);
            tbHK.Location = new Point(6, 54);
            tbHK.Name = "tbHK";
            tbHK.PlaceholderText = "Nhập học kỳ";
            tbHK.Size = new Size(344, 27);
            tbHK.TabIndex = 4;
            // 
            // tbMAHP
            // 
            tbMAHP.Font = new Font("Segoe UI", 9F);
            tbMAHP.Location = new Point(475, 127);
            tbMAHP.Name = "tbMAHP";
            tbMAHP.PlaceholderText = "Nhập mã học phần";
            tbMAHP.Size = new Size(344, 27);
            tbMAHP.TabIndex = 0;
            // 
            // gboxTimkiem
            // 
            gboxTimkiem.Controls.Add(label5);
            gboxTimkiem.Controls.Add(tbTENHP);
            gboxTimkiem.Controls.Add(label7);
            gboxTimkiem.Controls.Add(tbSOTC);
            gboxTimkiem.Controls.Add(label4);
            gboxTimkiem.Controls.Add(tbMADV);
            gboxTimkiem.Controls.Add(label3);
            gboxTimkiem.Controls.Add(label2);
            gboxTimkiem.Controls.Add(label1);
            gboxTimkiem.Controls.Add(tbNAM);
            gboxTimkiem.Controls.Add(tbHK);
            gboxTimkiem.Controls.Add(tbMAHP);
            gboxTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTimkiem.Location = new Point(12, 98);
            gboxTimkiem.Name = "gboxTimkiem";
            gboxTimkiem.Size = new Size(1291, 183);
            gboxTimkiem.TabIndex = 7;
            gboxTimkiem.TabStop = false;
            gboxTimkiem.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 104);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 21;
            label5.Text = "Tên học phần";
            // 
            // tbTENHP
            // 
            tbTENHP.Font = new Font("Segoe UI", 9F);
            tbTENHP.Location = new Point(6, 127);
            tbTENHP.Name = "tbTENHP";
            tbTENHP.PlaceholderText = "Nhập tên học phần";
            tbTENHP.Size = new Size(344, 27);
            tbTENHP.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(941, 104);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 19;
            label7.Text = "Số tín chỉ ";
            // 
            // tbSOTC
            // 
            tbSOTC.Font = new Font("Segoe UI", 9F);
            tbSOTC.Location = new Point(941, 127);
            tbSOTC.Name = "tbSOTC";
            tbSOTC.PlaceholderText = "Nhập số tín chỉ";
            tbSOTC.Size = new Size(344, 27);
            tbSOTC.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(941, 31);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 17;
            label4.Text = "Mã đơn vị";
            // 
            // tbMADV
            // 
            tbMADV.Font = new Font("Segoe UI", 9F);
            tbMADV.Location = new Point(941, 54);
            tbMADV.Name = "tbMADV";
            tbMADV.PlaceholderText = "Nhập mã đơn vị";
            tbMADV.Size = new Size(344, 27);
            tbMADV.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 15;
            label3.Text = "Học kỳ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(475, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 14;
            label2.Text = "Năm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(475, 104);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 13;
            label1.Text = "Mã học phần";
            // 
            // dtgviewKHMO
            // 
            dtgviewKHMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewKHMO.Location = new Point(12, 287);
            dtgviewKHMO.Name = "dtgviewKHMO";
            dtgviewKHMO.RowHeadersWidth = 51;
            dtgviewKHMO.Size = new Size(1291, 353);
            dtgviewKHMO.TabIndex = 6;
            // 
            // NV_DanhSachKHMO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(panel1);
            Controls.Add(gboxTimkiem);
            Controls.Add(dtgviewKHMO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_DanhSachKHMO";
            Text = "NV_DanhSachKHMO";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gboxTimkiem.ResumeLayout(false);
            gboxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewKHMO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private TextBox tbNAM;
        private TextBox tbHK;
        private TextBox tbMAHP;
        private GroupBox gboxTimkiem;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgviewKHMO;
        private Label label4;
        private TextBox tbMADV;
        private Label label5;
        private TextBox tbTENHP;
        private Label label7;
        private TextBox tbSOTC;
    }
}