namespace ATTT
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBtn = new Button();
            mainLabel = new Label();
            usernameBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordBox = new TextBox();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Bottom;
            loginBtn.AutoSize = true;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(173, 245);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(95, 30);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // mainLabel
            // 
            mainLabel.Anchor = AnchorStyles.Top;
            mainLabel.AutoSize = true;
            mainLabel.BorderStyle = BorderStyle.Fixed3D;
            mainLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            mainLabel.Location = new Point(35, 26);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(377, 39);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "ỨNG DỤNG QUẢN TRỊ CSDL";
            mainLabel.TextAlign = ContentAlignment.TopCenter;
            mainLabel.Click += label1_Click;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = SystemColors.Window;
            usernameBox.Location = new Point(35, 111);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(377, 27);
            usernameBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(35, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(35, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = SystemColors.Window;
            passwordBox.Location = new Point(35, 181);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(377, 27);
            passwordBox.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 291);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameBox);
            Controls.Add(mainLabel);
            Controls.Add(loginBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Text = "ỨNG DỤNG QUẢN TRỊ CSDL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label mainLabel;
        private TextBox usernameBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordBox;
    }
}
