namespace ATTT
{
    partial class GrantPrivForm
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
            UserRoleLabel = new Label();
            UserRoleBox = new TextBox();
            CheckButton = new Button();
            GrantPrivTable = new DataGridView();
            GrantButton = new Button();
            TableNameCol = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewCheckBoxColumn();
            ICol = new DataGridViewCheckBoxColumn();
            UCol = new DataGridViewCheckBoxColumn();
            DCol = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            UserRoleLabel.Location = new Point(50, 21);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(183, 30);
            UserRoleLabel.TabIndex = 0;
            UserRoleLabel.Text = "Username/Role: ";
            // 
            // UserRoleBox
            // 
            UserRoleBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserRoleBox.Location = new Point(250, 19);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(609, 37);
            UserRoleBox.TabIndex = 1;
            // 
            // CheckButton
            // 
            CheckButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckButton.BackColor = Color.RoyalBlue;
            CheckButton.FlatAppearance.BorderColor = Color.White;
            CheckButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckButton.Location = new Point(879, 16);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(124, 40);
            CheckButton.TabIndex = 2;
            CheckButton.Text = "Kiểm tra";
            CheckButton.UseVisualStyleBackColor = false;
            CheckButton.Click += CheckButton_Click;
            // 
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { TableNameCol, SCol, ICol, UCol, DCol });
            GrantPrivTable.Location = new Point(250, 72);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(753, 471);
            GrantPrivTable.TabIndex = 3;
            // 
            // GrantButton
            // 
            GrantButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantButton.BackColor = Color.Lime;
            GrantButton.FlatAppearance.BorderColor = Color.White;
            GrantButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrantButton.Location = new Point(1028, 16);
            GrantButton.Name = "GrantButton";
            GrantButton.Size = new Size(139, 40);
            GrantButton.TabIndex = 4;
            GrantButton.Text = "Cấp quyền";
            GrantButton.UseVisualStyleBackColor = false;
            GrantButton.Click += GrantButton_Click;
            // 
            // TableNameCol
            // 
            TableNameCol.HeaderText = "TABLE";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            TableNameCol.Width = 200;
            // 
            // SCol
            // 
            SCol.HeaderText = "SELECT";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ThreeState = true;
            SCol.Width = 125;
            // 
            // ICol
            // 
            ICol.HeaderText = "INSERT";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ThreeState = true;
            ICol.Width = 125;
            // 
            // UCol
            // 
            UCol.HeaderText = "UPDATE";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ThreeState = true;
            UCol.Width = 125;
            // 
            // DCol
            // 
            DCol.HeaderText = "DELETE";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.Resizable = DataGridViewTriState.True;
            DCol.ThreeState = true;
            DCol.Width = 125;
            // 
            // GrantPrivForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 555);
            Controls.Add(GrantButton);
            Controls.Add(GrantPrivTable);
            Controls.Add(CheckButton);
            Controls.Add(UserRoleBox);
            Controls.Add(UserRoleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GrantPrivForm";
            Text = "GrantPrivForm";
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserRoleLabel;
        private TextBox UserRoleBox;
        private Button CheckButton;
        private DataGridView GrantPrivTable;
        private Button GrantButton;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewCheckBoxColumn SCol;
        private DataGridViewCheckBoxColumn ICol;
        private DataGridViewCheckBoxColumn UCol;
        private DataGridViewCheckBoxColumn DCol;
    }
}