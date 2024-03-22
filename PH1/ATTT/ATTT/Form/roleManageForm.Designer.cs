namespace ATTT
{
    partial class roleManageForm
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
            Add = new Button();
            groupBox1 = new GroupBox();
            Modify = new Button();
            Role = new TextBox();
            Delete = new Button();
            label2 = new Label();
            Password = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            findUser = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Add.Location = new Point(117, 117);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 0;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Modify);
            groupBox1.Controls.Add(Role);
            groupBox1.Controls.Add(Delete);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(249, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 189);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý Role";
            // 
            // Modify
            // 
            Modify.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Modify.Location = new Point(561, 117);
            Modify.Name = "Modify";
            Modify.Size = new Size(128, 29);
            Modify.TabIndex = 8;
            Modify.Text = "Đổi mật khẩu";
            Modify.UseVisualStyleBackColor = true;
            Modify.Click += Modify_Click;
            // 
            // Role
            // 
            Role.Location = new Point(115, 43);
            Role.Name = "Role";
            Role.Size = new Size(125, 27);
            Role.TabIndex = 4;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Delete.Location = new Point(341, 117);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 7;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(466, 49);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            // 
            // Password
            // 
            Password.Location = new Point(542, 46);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(125, 27);
            Password.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên role";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(findUser);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(249, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(778, 285);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(534, 25);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm";
            // 
            // findUser
            // 
            findUser.Location = new Point(615, 22);
            findUser.Name = "findUser";
            findUser.Size = new Size(125, 27);
            findUser.TabIndex = 6;
            findUser.TextChanged += findUser_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(16, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(724, 219);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên role";
            columnHeader1.Width = 724;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(548, 18);
            label3.Name = "label3";
            label3.Size = new Size(196, 41);
            label3.TabIndex = 7;
            label3.Text = "Quản lý Role";
            label3.Click += label3_Click;
            // 
            // roleManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "roleManageForm";
            Text = "roleManageForm";
            Load += roleManageForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private GroupBox groupBox1;
        private Button Modify;
        private TextBox Role;
        private Button Delete;
        private Label label2;
        private TextBox Password;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox findUser;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label3;
    }
}