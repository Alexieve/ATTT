namespace ATTT
{
    partial class GrantRoleForm
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
            RoleTable = new DataGridView();
            GRANTEE = new DataGridViewTextBoxColumn();
            GRANTED_ROLE = new DataGridViewTextBoxColumn();
            RoleBox = new ComboBox();
            RoleLabel = new Label();
            GrantButton = new Button();
            CheckButton = new Button();
            UserRoleLabel = new Label();
            RevokeButton = new Button();
            UserRoleBox = new ComboBox();
            changeObj = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)RoleTable).BeginInit();
            SuspendLayout();
            // 
            // RoleTable
            // 
            RoleTable.AllowUserToAddRows = false;
            RoleTable.AllowUserToDeleteRows = false;
            RoleTable.Anchor = AnchorStyles.Bottom;
            RoleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoleTable.Columns.AddRange(new DataGridViewColumn[] { GRANTEE, GRANTED_ROLE });
            RoleTable.Location = new Point(12, 99);
            RoleTable.Name = "RoleTable";
            RoleTable.RowHeadersWidth = 51;
            RoleTable.Size = new Size(1289, 444);
            RoleTable.TabIndex = 18;
            // 
            // GRANTEE
            // 
            GRANTEE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GRANTEE.HeaderText = "GRANTEE";
            GRANTEE.MinimumWidth = 6;
            GRANTEE.Name = "GRANTEE";
            GRANTEE.ReadOnly = true;
            // 
            // GRANTED_ROLE
            // 
            GRANTED_ROLE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GRANTED_ROLE.HeaderText = "GRANTED_ROLE";
            GRANTED_ROLE.MinimumWidth = 6;
            GRANTED_ROLE.Name = "GRANTED_ROLE";
            GRANTED_ROLE.ReadOnly = true;
            // 
            // RoleBox
            // 
            RoleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleBox.Font = new Font("Segoe UI", 13.2000008F);
            RoleBox.FormattingEnabled = true;
            RoleBox.Location = new Point(702, 13);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(324, 38);
            RoleBox.TabIndex = 17;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            RoleLabel.Location = new Point(629, 20);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(57, 30);
            RoleLabel.TabIndex = 16;
            RoleLabel.Text = "Role";
            // 
            // GrantButton
            // 
            GrantButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantButton.BackColor = Color.Lime;
            GrantButton.FlatAppearance.BorderColor = Color.White;
            GrantButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrantButton.Location = new Point(1032, 11);
            GrantButton.Name = "GrantButton";
            GrantButton.Size = new Size(124, 40);
            GrantButton.TabIndex = 15;
            GrantButton.Text = "Cấp role";
            GrantButton.UseVisualStyleBackColor = false;
            GrantButton.Click += GrantButton_Click;
            // 
            // CheckButton
            // 
            CheckButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckButton.BackColor = Color.RoyalBlue;
            CheckButton.FlatAppearance.BorderColor = Color.White;
            CheckButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckButton.Location = new Point(499, 11);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(124, 40);
            CheckButton.TabIndex = 14;
            CheckButton.Text = "Kiểm tra";
            CheckButton.UseVisualStyleBackColor = false;
            CheckButton.Click += CheckButton_Click;
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            UserRoleLabel.Location = new Point(12, 20);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(183, 30);
            UserRoleLabel.TabIndex = 12;
            UserRoleLabel.Text = "Username/Role: ";
            // 
            // RevokeButton
            // 
            RevokeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RevokeButton.BackColor = Color.Red;
            RevokeButton.FlatAppearance.BorderColor = Color.White;
            RevokeButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RevokeButton.Location = new Point(1162, 11);
            RevokeButton.Name = "RevokeButton";
            RevokeButton.Size = new Size(124, 40);
            RevokeButton.TabIndex = 19;
            RevokeButton.Text = "Thu hồi";
            RevokeButton.UseVisualStyleBackColor = false;
            RevokeButton.Click += RevokeButton_Click;
            // 
            // UserRoleBox
            // 
            UserRoleBox.Font = new Font("Segoe UI", 13.2000008F);
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.Location = new Point(201, 13);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(292, 38);
            UserRoleBox.TabIndex = 20;
            // 
            // changeObj
            // 
            changeObj.AutoSize = true;
            changeObj.Location = new Point(18, 58);
            changeObj.Name = "changeObj";
            changeObj.Size = new Size(144, 24);
            changeObj.TabIndex = 21;
            changeObj.Text = "Chuyển sang role";
            changeObj.UseVisualStyleBackColor = true;
            changeObj.CheckedChanged += changeObj_CheckedChanged;
            // 
            // GrantRoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 555);
            Controls.Add(changeObj);
            Controls.Add(UserRoleBox);
            Controls.Add(RevokeButton);
            Controls.Add(RoleTable);
            Controls.Add(RoleBox);
            Controls.Add(RoleLabel);
            Controls.Add(GrantButton);
            Controls.Add(CheckButton);
            Controls.Add(UserRoleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GrantRoleForm";
            Text = "GrantRoleForm";
            ((System.ComponentModel.ISupportInitialize)RoleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoleTable;
        private ComboBox RoleBox;
        private Label RoleLabel;
        private Button GrantButton;
        private Button CheckButton;
        private Label UserRoleLabel;
        private DataGridViewTextBoxColumn GRANTEE;
        private DataGridViewTextBoxColumn GRANTED_ROLE;
        private Button RevokeButton;
        private ComboBox UserRoleBox;
        private CheckBox changeObj;
    }
}