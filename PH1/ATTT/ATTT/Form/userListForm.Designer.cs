using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATTT
{
    partial class userListForm
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
            GrantPrivTable = new DataGridView();
            TableNameCol = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewTextBoxColumn();
            ICol = new DataGridViewTextBoxColumn();
            UCol = new DataGridViewTextBoxColumn();
            DCol = new DataGridViewTextBoxColumn();
            label3 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { TableNameCol, SCol, ICol, UCol, DCol });
            GrantPrivTable.Location = new Point(13, 103);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1289, 516);
            GrantPrivTable.TabIndex = 4;
            // 
            // TableNameCol
            // 
            TableNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableNameCol.HeaderText = "USERNAME";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SCol.HeaderText = "ACCOUNT_STATUS";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ReadOnly = true;
            // 
            // ICol
            // 
            ICol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ICol.HeaderText = "DEFAULT_TABLESPACE";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ReadOnly = true;
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UCol.HeaderText = "CREATED";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ReadOnly = true;
            // 
            // DCol
            // 
            DCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DCol.HeaderText = "AUTHENCATION_TYPE";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.Resizable = DataGridViewTriState.True;
            DCol.ReadOnly = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(548, 18);
            label3.Name = "label3";
            label3.Size = new Size(232, 41);
            label3.TabIndex = 5;
            label3.Text = "Danh sách User";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 7;
            label1.Text = "USERNAME: ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // userListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(label3);
            Controls.Add(GrantPrivTable);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userListForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrantPrivTable;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewTextBoxColumn SCol;
        private DataGridViewTextBoxColumn ICol;
        private DataGridViewTextBoxColumn UCol;
        private DataGridViewTextBoxColumn DCol;
        private TextBox txtSearch;
        private Label label1;
        private Label label3;
        private Button btnSearch;
        
    }

}
