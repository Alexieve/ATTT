﻿namespace PH2.GUI
{
    partial class GIAOVU_DV_CapNhat
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
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
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
            label3.Size = new Size(1053, 52);
            label3.TabIndex = 5;
            label3.Text = "Cập Nhật Đơn Vị";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox3);
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(473, 302);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "VD: NV00000001";
            textBox3.Size = new Size(388, 48);
            textBox3.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(121, 315);
            label2.Name = "label2";
            label2.Size = new Size(224, 35);
            label2.TabIndex = 38;
            label2.Text = "Mã Trưởng Đơn Vị:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(473, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "VD: Văn phòng khoa";
            textBox2.Size = new Size(388, 51);
            textBox2.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(121, 223);
            label1.Name = "label1";
            label1.Size = new Size(141, 35);
            label1.TabIndex = 36;
            label1.Text = "Tên Đơn Vị:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(473, 139);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "VD: VPK";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(388, 51);
            textBox1.TabIndex = 35;
            // 
            // button2
            // 
            button2.Location = new Point(760, 527);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 34;
            button2.Text = "Cập Nhật";
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
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(121, 142);
            label9.Name = "label9";
            label9.Size = new Size(145, 35);
            label9.TabIndex = 31;
            label9.Text = "Mã Đơn Vị: ";
            // 
            // GIAOVU_DV_CapNhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 589);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(120, 169);
            Name = "GIAOVU_DV_CapNhat";
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
        private TextBox textBox3;
    }
}