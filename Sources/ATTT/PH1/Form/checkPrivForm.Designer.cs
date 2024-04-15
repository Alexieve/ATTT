namespace ATTT
{
    partial class checkPrivForm
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
            toppnTab = new FlowLayoutPanel();
            pnInputTab = new Panel();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tbInputTab = new ComboBox();
            btnTabRole = new Button();
            tcCheckPriv = new TabControl();
            tpCol = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            COLUMN_NAME = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnCol = new Button();
            tpTab = new TabPage();
            dtgTab = new DataGridView();
            GRANTEE = new DataGridViewTextBoxColumn();
            TABLE_NAME = new DataGridViewTextBoxColumn();
            PRIVILEGE = new DataGridViewTextBoxColumn();
            GRANTOR = new DataGridViewTextBoxColumn();
            GRANTABLE = new DataGridViewTextBoxColumn();
            TYPE = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            comboBox1 = new ComboBox();
            toppnTab.SuspendLayout();
            pnInputTab.SuspendLayout();
            groupBox1.SuspendLayout();
            tcCheckPriv.SuspendLayout();
            tpCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTab).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toppnTab
            // 
            toppnTab.BackColor = SystemColors.Info;
            toppnTab.Controls.Add(pnInputTab);
            toppnTab.Controls.Add(btnTabRole);
            toppnTab.Location = new Point(6, 6);
            toppnTab.Name = "toppnTab";
            toppnTab.Size = new Size(1271, 113);
            toppnTab.TabIndex = 0;
            // 
            // pnInputTab
            // 
            pnInputTab.Controls.Add(groupBox1);
            pnInputTab.Location = new Point(3, 3);
            pnInputTab.Name = "pnInputTab";
            pnInputTab.Size = new Size(683, 110);
            pnInputTab.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(tbInputTab);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 104);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác định người dùng hoặc vai trò";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(187, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Vai trò";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(26, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Người dùng";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tbInputTab
            // 
            tbInputTab.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbInputTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbInputTab.FormattingEnabled = true;
            tbInputTab.Location = new Point(333, 40);
            tbInputTab.Name = "tbInputTab";
            tbInputTab.Size = new Size(307, 28);
            tbInputTab.TabIndex = 2;
            // 
            // btnTabRole
            // 
            btnTabRole.BackColor = Color.FromArgb(64, 64, 64);
            btnTabRole.ForeColor = Color.White;
            btnTabRole.Location = new Point(692, 3);
            btnTabRole.Name = "btnTabRole";
            btnTabRole.Size = new Size(500, 110);
            btnTabRole.TabIndex = 1;
            btnTabRole.Text = "Kiểm tra quyền";
            btnTabRole.UseVisualStyleBackColor = false;
            btnTabRole.Click += btnTabRole_Click;
            // 
            // tcCheckPriv
            // 
            tcCheckPriv.Controls.Add(tpCol);
            tcCheckPriv.Controls.Add(tpTab);
            tcCheckPriv.Location = new Point(12, 12);
            tcCheckPriv.Name = "tcCheckPriv";
            tcCheckPriv.SelectedIndex = 0;
            tcCheckPriv.Size = new Size(1291, 628);
            tcCheckPriv.TabIndex = 2;
            // 
            // tpCol
            // 
            tpCol.Controls.Add(dataGridView1);
            tpCol.Controls.Add(flowLayoutPanel1);
            tpCol.Location = new Point(4, 29);
            tpCol.Name = "tpCol";
            tpCol.Padding = new Padding(3);
            tpCol.Size = new Size(1283, 595);
            tpCol.TabIndex = 0;
            tpCol.Text = "Theo cột";
            tpCol.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, COLUMN_NAME, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView1.Location = new Point(6, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1271, 442);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "GRANTEE";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "TABLE_NAME";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // COLUMN_NAME
            // 
            COLUMN_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COLUMN_NAME.HeaderText = "COLUMN_NAME";
            COLUMN_NAME.MinimumWidth = 6;
            COLUMN_NAME.Name = "COLUMN_NAME";
            COLUMN_NAME.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "PRIVILEGE";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "GRANTOR";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "GRANTABLE";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "TYPE";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnCol);
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1271, 113);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 110);
            panel1.TabIndex = 1;
            // 
            // btnCol
            // 
            btnCol.BackColor = Color.FromArgb(64, 64, 64);
            btnCol.ForeColor = Color.White;
            btnCol.Location = new Point(692, 3);
            btnCol.Name = "btnCol";
            btnCol.Size = new Size(500, 110);
            btnCol.TabIndex = 1;
            btnCol.Text = "Kiểm tra quyền";
            btnCol.UseVisualStyleBackColor = false;
            btnCol.Click += btnCol_Click;
            // 
            // tpTab
            // 
            tpTab.Controls.Add(dtgTab);
            tpTab.Controls.Add(toppnTab);
            tpTab.Location = new Point(4, 29);
            tpTab.Name = "tpTab";
            tpTab.Padding = new Padding(3);
            tpTab.Size = new Size(1283, 595);
            tpTab.TabIndex = 1;
            tpTab.Text = "Theo bảng";
            tpTab.UseVisualStyleBackColor = true;
            // 
            // dtgTab
            // 
            dtgTab.BackgroundColor = Color.White;
            dtgTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTab.Columns.AddRange(new DataGridViewColumn[] { GRANTEE, TABLE_NAME, PRIVILEGE, GRANTOR, GRANTABLE, TYPE });
            dtgTab.Location = new Point(6, 151);
            dtgTab.Name = "dtgTab";
            dtgTab.RowHeadersWidth = 51;
            dtgTab.Size = new Size(1271, 442);
            dtgTab.TabIndex = 1;
            // 
            // GRANTEE
            // 
            GRANTEE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GRANTEE.HeaderText = "GRANTEE";
            GRANTEE.MinimumWidth = 6;
            GRANTEE.Name = "GRANTEE";
            GRANTEE.ReadOnly = true;
            // 
            // TABLE_NAME
            // 
            TABLE_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TABLE_NAME.HeaderText = "TABLE_NAME";
            TABLE_NAME.MinimumWidth = 6;
            TABLE_NAME.Name = "TABLE_NAME";
            TABLE_NAME.ReadOnly = true;
            // 
            // PRIVILEGE
            // 
            PRIVILEGE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PRIVILEGE.HeaderText = "PRIVILEGE";
            PRIVILEGE.MinimumWidth = 6;
            PRIVILEGE.Name = "PRIVILEGE";
            PRIVILEGE.ReadOnly = true;
            // 
            // GRANTOR
            // 
            GRANTOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GRANTOR.HeaderText = "GRANTOR";
            GRANTOR.MinimumWidth = 6;
            GRANTOR.Name = "GRANTOR";
            GRANTOR.ReadOnly = true;
            // 
            // GRANTABLE
            // 
            GRANTABLE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GRANTABLE.HeaderText = "GRANTABLE";
            GRANTABLE.MinimumWidth = 6;
            GRANTABLE.Name = "GRANTABLE";
            GRANTABLE.ReadOnly = true;
            // 
            // TYPE
            // 
            TYPE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TYPE.HeaderText = "TYPE";
            TYPE.MinimumWidth = 6;
            TYPE.Name = "TYPE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 104);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xác định người dùng hoặc vai trò";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(187, 40);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vai trò";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(26, 40);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(110, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Người dùng";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(333, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 28);
            comboBox1.TabIndex = 2;
            // 
            // checkPrivForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(tcCheckPriv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "checkPrivForm";
            Text = "checkPrivForm";
            toppnTab.ResumeLayout(false);
            pnInputTab.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tcCheckPriv.ResumeLayout(false);
            tpCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tpTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgTab).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel toppnTab;
        private Panel pnInputTab;
        private TabControl tcCheckPriv;
        private TabPage tpCol;
        private TabPage tpTab;
        private DataGridView dtgTab;
        private Button btnTabRole;
        private DataGridViewTextBoxColumn GRANTEE;
        private DataGridViewTextBoxColumn TABLE_NAME;
        private DataGridViewTextBoxColumn PRIVILEGE;
        private DataGridViewTextBoxColumn GRANTOR;
        private DataGridViewTextBoxColumn GRANTABLE;
        private DataGridViewTextBoxColumn TYPE;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn COLUMN_NAME;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnCol;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox tbInputTab;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ComboBox comboBox1;
    }
}