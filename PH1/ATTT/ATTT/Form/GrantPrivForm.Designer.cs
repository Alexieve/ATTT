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
            CheckButton = new Button();
            GrantPrivTable = new DataGridView();
            TableNameCol = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewCheckBoxColumn();
            ICol = new DataGridViewCheckBoxColumn();
            UCol = new DataGridViewCheckBoxColumn();
            DCol = new DataGridViewCheckBoxColumn();
            GrantButton = new Button();
            changeObj = new CheckBox();
            UserRoleBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            UserRoleLabel.Location = new Point(162, 19);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(183, 30);
            UserRoleLabel.TabIndex = 0;
            UserRoleLabel.Text = "Username/Role: ";
            // 
            // CheckButton
            // 
            CheckButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckButton.BackColor = Color.RoyalBlue;
            CheckButton.FlatAppearance.BorderColor = Color.White;
            CheckButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckButton.Location = new Point(1032, 11);
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
            GrantPrivTable.Location = new Point(12, 72);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1289, 471);
            GrantPrivTable.TabIndex = 3;
            // 
            // TableNameCol
            // 
            TableNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableNameCol.HeaderText = "TABLE";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SCol.HeaderText = "SELECT";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ThreeState = true;
            // 
            // ICol
            // 
            ICol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ICol.HeaderText = "INSERT";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ThreeState = true;
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UCol.HeaderText = "UPDATE";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ThreeState = true;
            // 
            // DCol
            // 
            DCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DCol.HeaderText = "DELETE";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.Resizable = DataGridViewTriState.True;
            DCol.ThreeState = true;
            // 
            // GrantButton
            // 
            GrantButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrantButton.BackColor = Color.Lime;
            GrantButton.FlatAppearance.BorderColor = Color.White;
            GrantButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrantButton.Location = new Point(1162, 11);
            GrantButton.Name = "GrantButton";
            GrantButton.Size = new Size(139, 40);
            GrantButton.TabIndex = 4;
            GrantButton.Text = "Cấp quyền";
            GrantButton.UseVisualStyleBackColor = false;
            GrantButton.Click += GrantButton_Click;
            // 
            // changeObj
            // 
            changeObj.AutoSize = true;
            changeObj.Location = new Point(12, 25);
            changeObj.Name = "changeObj";
            changeObj.Size = new Size(144, 24);
            changeObj.TabIndex = 5;
            changeObj.Text = "Chuyển sang role";
            changeObj.UseVisualStyleBackColor = true;
            changeObj.CheckedChanged += changeObj_CheckedChanged;
            // 
            // UserRoleBox
            // 
            UserRoleBox.Font = new Font("Segoe UI", 13.2000008F);
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.Location = new Point(351, 13);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(675, 38);
            UserRoleBox.TabIndex = 6;
            // 
            // GrantPrivForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 555);
            Controls.Add(UserRoleBox);
            Controls.Add(changeObj);
            Controls.Add(GrantButton);
            Controls.Add(GrantPrivTable);
            Controls.Add(CheckButton);
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
        private Button CheckButton;
        private DataGridView GrantPrivTable;
        private Button GrantButton;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewCheckBoxColumn SCol;
        private DataGridViewCheckBoxColumn ICol;
        private DataGridViewCheckBoxColumn UCol;
        private DataGridViewCheckBoxColumn DCol;
        private CheckBox changeObj;
        private ComboBox UserRoleBox;
    }
}