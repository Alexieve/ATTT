namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    partial class YesNoDialog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrompt = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrompt.Location = new Point(20, 48);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(406, 25);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "Bạn có muốn xóa những Đăng Ký tương ứng ?";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(73, 122);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Đồng ý";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(278, 122);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // YesNoDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelPrompt);
            Name = "YesNoDialog";
            Size = new Size(441, 192);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrompt;
        private Button button1;
        private Button button2;
    }
}
