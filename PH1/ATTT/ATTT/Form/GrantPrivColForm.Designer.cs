namespace ATTT
{
    partial class GrantPrivColForm
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
            GrantButton = new Button();
            CheckButton = new Button();
            UserRoleLabel = new Label();
            TableLabel = new Label();
            TableBox = new ComboBox();
            GrantPrivTable = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewCheckBoxColumn();
            UCol = new DataGridViewCheckBoxColumn();
            changeObj = new CheckBox();
            UserRoleBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
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
            GrantButton.TabIndex = 8;
            GrantButton.Text = "Cấp quyền";
            GrantButton.UseVisualStyleBackColor = false;
            GrantButton.Click += GrantButton_Click;
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
            CheckButton.TabIndex = 7;
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
            UserRoleLabel.TabIndex = 5;
            UserRoleLabel.Text = "Username/Role: ";
            // 
            // TableLabel
            // 
            TableLabel.AutoSize = true;
            TableLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            TableLabel.Location = new Point(590, 20);
            TableLabel.Name = "TableLabel";
            TableLabel.Size = new Size(68, 30);
            TableLabel.TabIndex = 9;
            TableLabel.Text = "Table";
            // 
            // TableBox
            // 
            TableBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TableBox.Font = new Font("Segoe UI", 13.2000008F);
            TableBox.FormattingEnabled = true;
            TableBox.Location = new Point(664, 13);
            TableBox.Name = "TableBox";
            TableBox.Size = new Size(348, 38);
            TableBox.TabIndex = 10;
            // 
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { ColName, SCol, UCol });
            GrantPrivTable.Location = new Point(12, 99);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1289, 444);
            GrantPrivTable.TabIndex = 11;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "COLUMN";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SCol.HeaderText = "SELECT";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UCol.HeaderText = "UPDATE";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ThreeState = true;
            // 
            // changeObj
            // 
            changeObj.AutoSize = true;
            changeObj.Location = new Point(18, 58);
            changeObj.Name = "changeObj";
            changeObj.Size = new Size(144, 24);
            changeObj.TabIndex = 12;
            changeObj.Text = "Chuyển sang role";
            changeObj.UseVisualStyleBackColor = true;
            changeObj.CheckedChanged += changeObj_CheckedChanged;
            // 
            // UserRoleBox
            // 
            UserRoleBox.DropDownHeight = 300;
            UserRoleBox.Font = new Font("Segoe UI", 13.2000008F);
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.IntegralHeight = false;
            UserRoleBox.Location = new Point(201, 13);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.Size = new Size(383, 38);
            UserRoleBox.TabIndex = 13;
            // 
            // GrantPrivColForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 555);
            Controls.Add(UserRoleBox);
            Controls.Add(changeObj);
            Controls.Add(GrantPrivTable);
            Controls.Add(TableBox);
            Controls.Add(TableLabel);
            Controls.Add(GrantButton);
            Controls.Add(CheckButton);
            Controls.Add(UserRoleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GrantPrivColForm";
            Text = "GrantPrivColForm";
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GrantButton;
        private Button CheckButton;
        private Label UserRoleLabel;
        private Label TableLabel;
        private ComboBox TableBox;
        private DataGridView GrantPrivTable;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewCheckBoxColumn SCol;
        private DataGridViewCheckBoxColumn UCol;
        private CheckBox changeObj;
        private ComboBox UserRoleBox;
    }
}