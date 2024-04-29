namespace PH2.GUI
{
    partial class GIAOVU_DV_Them
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
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            HKNamCbb = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1053, 52);
            label3.TabIndex = 5;
            label3.Text = "Thêm Đơn Vị Mới";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(HKNamCbb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 589);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 331);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 38;
            label2.Text = "Mã Trưởng Đơn Vị:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(269, 236);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "VD: Văn phòng khoa";
            textBox2.Size = new Size(401, 40);
            textBox2.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(33, 239);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 36;
            label1.Text = "Tên Đơn Vị:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(269, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "VD: VPK";
            textBox1.Size = new Size(401, 39);
            textBox1.TabIndex = 35;
            // 
            // button2
            // 
            button2.Location = new Point(760, 527);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 34;
            button2.Text = "Thêm";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(215, 527);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 33;
            button3.Text = "Hủy";
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(33, 158);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 31;
            label9.Text = "Mã Đơn Vị: ";
            // 
            // HKNamCbb
            // 
            HKNamCbb.DropDownHeight = 160;
            HKNamCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            HKNamCbb.Font = new Font("Segoe UI", 12F);
            HKNamCbb.FormattingEnabled = true;
            HKNamCbb.IntegralHeight = false;
            HKNamCbb.Location = new Point(269, 328);
            HKNamCbb.Name = "HKNamCbb";
            HKNamCbb.Size = new Size(730, 36);
            HKNamCbb.TabIndex = 59;
            // 
            // GIAOVU_DV_Them
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 589);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(120, 169);
            Name = "GIAOVU_DV_Them";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;

        private Panel panel1;
        private Label label9;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private ComboBox HKNamCbb;
    }
}