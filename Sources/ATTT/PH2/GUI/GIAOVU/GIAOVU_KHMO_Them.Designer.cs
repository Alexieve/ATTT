

namespace PH2.GUI
{
    partial class GIAOVU_KHMO_Them
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
            HKNamCbb = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(861, 52);
            label3.TabIndex = 5;
            label3.Text = "Thêm KHMO Mới";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(HKNamCbb);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 589);
            panel1.TabIndex = 19;
            // 
            // HKNamCbb
            // 
            HKNamCbb.DropDownHeight = 160;
            HKNamCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            HKNamCbb.Font = new Font("Segoe UI", 9F);
            HKNamCbb.FormattingEnabled = true;
            HKNamCbb.IntegralHeight = false;
            HKNamCbb.Location = new Point(258, 168);
            HKNamCbb.Name = "HKNamCbb";
            HKNamCbb.Size = new Size(282, 28);
            HKNamCbb.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 249);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 28);
            textBox3.TabIndex = 54;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 294);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 28);
            textBox4.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 297);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 40;
            label4.Text = "Mã Chương Trình:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 252);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 38;
            label2.Text = "Năm:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 209);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 28);
            textBox2.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 212);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 36;
            label1.Text = "Học kì:";
            // 
            // button2
            // 
            button2.Location = new Point(615, 512);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 34;
            button2.Text = "Thêm";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 527);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 33;
            button3.Text = "Hủy";
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 171);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 31;
            label9.Text = "Mã Học Phần: ";
            // 
            // GIAOVU_KHMO_Them
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 589);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(120, 169);
            Name = "GIAOVU_KHMO_Them";
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
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private ComboBox HKNamCbb;
    }
}