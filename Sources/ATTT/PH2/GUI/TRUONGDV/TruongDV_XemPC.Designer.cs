namespace PH2.GUI.TRUONGDV
{
    partial class TruongDV_XemPC
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
            dataGridView1 = new DataGridView();
            Deletebtn = new Button();
            addButton = new Button();
            label1 = new Label();
            ComboMAGV = new ComboBox();
            label2 = new Label();
            ComboMAHP = new ComboBox();
            label3 = new Label();
            ComboHK = new ComboBox();
            label4 = new Label();
            ComboNam = new ComboBox();
            label5 = new Label();
            ComboMACT = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            MAGV = new ComboBox();
            label10 = new Label();
            updateButton = new Button();
            MAHPBox = new TextBox();
            HKBox = new TextBox();
            NAMBox = new TextBox();
            MACTBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(942, 590);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Firebrick;
            Deletebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Deletebtn.ForeColor = SystemColors.ButtonHighlight;
            Deletebtn.Location = new Point(818, 5);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(119, 44);
            Deletebtn.TabIndex = 1;
            Deletebtn.Text = "Xóa";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Green;
            addButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(106, 7);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 42);
            addButton.TabIndex = 2;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(14, 62);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 3;
            label1.Text = "Mã giáo viên";
            // 
            // ComboMAGV
            // 
            ComboMAGV.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMAGV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboMAGV.FormattingEnabled = true;
            ComboMAGV.Location = new Point(142, 62);
            ComboMAGV.Name = "ComboMAGV";
            ComboMAGV.Size = new Size(151, 31);
            ComboMAGV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(14, 120);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 5;
            label2.Text = "Mã học phần";
            // 
            // ComboMAHP
            // 
            ComboMAHP.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMAHP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboMAHP.FormattingEnabled = true;
            ComboMAHP.Location = new Point(143, 120);
            ComboMAHP.Name = "ComboMAHP";
            ComboMAHP.Size = new Size(151, 31);
            ComboMAHP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(58, 177);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 7;
            label3.Text = "Học kì";
            // 
            // ComboHK
            // 
            ComboHK.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboHK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboHK.FormattingEnabled = true;
            ComboHK.Location = new Point(142, 174);
            ComboHK.Name = "ComboHK";
            ComboHK.Size = new Size(151, 33);
            ComboHK.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(72, 229);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 9;
            label4.Text = "Năm";
            // 
            // ComboNam
            // 
            ComboNam.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboNam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboNam.FormattingEnabled = true;
            ComboNam.Location = new Point(143, 230);
            ComboNam.Name = "ComboNam";
            ComboNam.Size = new Size(151, 33);
            ComboNam.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(59, 284);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 11;
            label5.Text = "Mã CT";
            // 
            // ComboMACT
            // 
            ComboMACT.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMACT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboMACT.FormattingEnabled = true;
            ComboMACT.Location = new Point(143, 284);
            ComboMACT.Name = "ComboMACT";
            ComboMACT.Size = new Size(151, 33);
            ComboMACT.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(58, 605);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 22;
            label6.Text = "Mã CT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(71, 550);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 20;
            label7.Text = "Năm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(57, 498);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 18;
            label8.Text = "Học kì";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(13, 441);
            label9.Name = "label9";
            label9.Size = new Size(123, 25);
            label9.TabIndex = 16;
            label9.Text = "Mã học phần";
            // 
            // MAGV
            // 
            MAGV.DropDownStyle = ComboBoxStyle.DropDownList;
            MAGV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MAGV.FormattingEnabled = true;
            MAGV.Location = new Point(141, 383);
            MAGV.Name = "MAGV";
            MAGV.Size = new Size(151, 31);
            MAGV.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(13, 383);
            label10.Name = "label10";
            label10.Size = new Size(122, 25);
            label10.TabIndex = 14;
            label10.Text = "Mã giáo viên";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Blue;
            updateButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(106, 335);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 42);
            updateButton.TabIndex = 13;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // MAHPBox
            // 
            MAHPBox.Location = new Point(143, 442);
            MAHPBox.Name = "MAHPBox";
            MAHPBox.ReadOnly = true;
            MAHPBox.Size = new Size(149, 27);
            MAHPBox.TabIndex = 24;
            // 
            // HKBox
            // 
            HKBox.Location = new Point(141, 499);
            HKBox.Name = "HKBox";
            HKBox.ReadOnly = true;
            HKBox.Size = new Size(149, 27);
            HKBox.TabIndex = 25;
            // 
            // NAMBox
            // 
            NAMBox.Location = new Point(141, 551);
            NAMBox.Name = "NAMBox";
            NAMBox.ReadOnly = true;
            NAMBox.Size = new Size(149, 27);
            NAMBox.TabIndex = 26;
            // 
            // MACTBox
            // 
            MACTBox.Location = new Point(141, 606);
            MACTBox.Name = "MACTBox";
            MACTBox.ReadOnly = true;
            MACTBox.Size = new Size(149, 27);
            MACTBox.TabIndex = 27;
            // 
            // TruongDV_XemPC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(MACTBox);
            Controls.Add(NAMBox);
            Controls.Add(HKBox);
            Controls.Add(MAHPBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(MAGV);
            Controls.Add(label10);
            Controls.Add(updateButton);
            Controls.Add(ComboMACT);
            Controls.Add(label5);
            Controls.Add(ComboNam);
            Controls.Add(label4);
            Controls.Add(ComboHK);
            Controls.Add(label3);
            Controls.Add(ComboMAHP);
            Controls.Add(label2);
            Controls.Add(ComboMAGV);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(Deletebtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TruongDV_XemPC";
            Text = "TruongDV_XemPC";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Deletebtn;
        private Button addButton;
        private Label label1;
        private ComboBox ComboMAGV;
        private Label label2;
        private ComboBox ComboMAHP;
        private Label label3;
        private ComboBox ComboHK;
        private Label label4;
        private ComboBox ComboNam;
        private Label label5;
        private ComboBox ComboMACT;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox MAGV;
        private Label label10;
        private Button updateButton;
        private TextBox MAHPBox;
        private TextBox HKBox;
        private TextBox NAMBox;
        private TextBox MACTBox;
    }
}