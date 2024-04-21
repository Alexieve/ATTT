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
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Firebrick;
            Deletebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Deletebtn.ForeColor = SystemColors.ButtonHighlight;
            Deletebtn.Location = new Point(818, 10);
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
            addButton.Location = new Point(106, 12);
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
            label1.Location = new Point(12, 84);
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
            ComboMAGV.Location = new Point(140, 84);
            ComboMAGV.Name = "ComboMAGV";
            ComboMAGV.Size = new Size(151, 31);
            ComboMAGV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 142);
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
            ComboMAHP.Location = new Point(141, 142);
            ComboMAHP.Name = "ComboMAHP";
            ComboMAHP.Size = new Size(151, 31);
            ComboMAHP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(56, 199);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 7;
            label3.Text = "Học kì";
            label3.Click += label3_Click;
            // 
            // ComboHK
            // 
            ComboHK.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboHK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ComboHK.FormattingEnabled = true;
            ComboHK.Location = new Point(140, 196);
            ComboHK.Name = "ComboHK";
            ComboHK.Size = new Size(151, 33);
            ComboHK.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(70, 251);
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
            ComboNam.Location = new Point(141, 252);
            ComboNam.Name = "ComboNam";
            ComboNam.Size = new Size(151, 33);
            ComboNam.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(57, 306);
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
            ComboMACT.Location = new Point(141, 306);
            ComboMACT.Name = "ComboMACT";
            ComboMACT.Size = new Size(151, 33);
            ComboMACT.TabIndex = 12;
            // 
            // TruongDV_XemPC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
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
    }
}