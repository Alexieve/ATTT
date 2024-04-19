namespace PH2.GUI.NV
{
    partial class NV_DanhSachDonVi
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
            label6 = new Label();
            panel1 = new Panel();
            tbTruongDV = new TextBox();
            tbTen = new TextBox();
            tbMaDV = new TextBox();
            gboxTimkiem = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgviewDonVi = new DataGridView();
            panel1.SuspendLayout();
            gboxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewDonVi).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(502, 25);
            label6.Name = "label6";
            label6.Size = new Size(292, 38);
            label6.TabIndex = 0;
            label6.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 98);
            panel1.TabIndex = 5;
            // 
            // tbTruongDV
            // 
            tbTruongDV.Font = new Font("Segoe UI", 9F);
            tbTruongDV.Location = new Point(956, 54);
            tbTruongDV.Name = "tbTruongDV";
            tbTruongDV.PlaceholderText = "Nhập mã trưởng đơn vị";
            tbTruongDV.Size = new Size(329, 27);
            tbTruongDV.TabIndex = 12;
            // 
            // tbTen
            // 
            tbTen.Font = new Font("Segoe UI", 9F);
            tbTen.Location = new Point(481, 54);
            tbTen.Name = "tbTen";
            tbTen.PlaceholderText = "Nhập tên đơn vị";
            tbTen.Size = new Size(329, 27);
            tbTen.TabIndex = 4;
            // 
            // tbMaDV
            // 
            tbMaDV.Font = new Font("Segoe UI", 9F);
            tbMaDV.Location = new Point(6, 54);
            tbMaDV.Name = "tbMaDV";
            tbMaDV.PlaceholderText = "Nhập mã đơn vị";
            tbMaDV.Size = new Size(329, 27);
            tbMaDV.TabIndex = 0;
            // 
            // gboxTimkiem
            // 
            gboxTimkiem.Controls.Add(label3);
            gboxTimkiem.Controls.Add(label2);
            gboxTimkiem.Controls.Add(label1);
            gboxTimkiem.Controls.Add(tbTruongDV);
            gboxTimkiem.Controls.Add(tbTen);
            gboxTimkiem.Controls.Add(tbMaDV);
            gboxTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTimkiem.Location = new Point(12, 98);
            gboxTimkiem.Name = "gboxTimkiem";
            gboxTimkiem.Size = new Size(1291, 102);
            gboxTimkiem.TabIndex = 4;
            gboxTimkiem.TabStop = false;
            gboxTimkiem.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(481, 31);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 15;
            label3.Text = "Tên đơn vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(956, 31);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã trưởng đơn vị";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 13;
            label1.Text = "Mã đơn vi";
            // 
            // dtgviewDonVi
            // 
            dtgviewDonVi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewDonVi.Location = new Point(12, 206);
            dtgviewDonVi.Name = "dtgviewDonVi";
            dtgviewDonVi.RowHeadersWidth = 51;
            dtgviewDonVi.Size = new Size(1291, 434);
            dtgviewDonVi.TabIndex = 3;
            // 
            // NV_DanhSachDonVi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(panel1);
            Controls.Add(gboxTimkiem);
            Controls.Add(dtgviewDonVi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_DanhSachDonVi";
            Text = "NV_DanhSachDonVi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gboxTimkiem.ResumeLayout(false);
            gboxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewDonVi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private TextBox tbTruongDV;
        private TextBox tbTen;
        private TextBox tbMaDV;
        private GroupBox gboxTimkiem;
        private DataGridView dtgviewDonVi;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}