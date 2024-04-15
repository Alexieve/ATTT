namespace PH2.GUI
{
    partial class SV_Profile
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
            MainPanel = new Panel();
            UpdateBtn = new Button();
            DTBTLPanel = new Panel();
            DTBTLLabel = new Label();
            DTBTLBox = new TextBox();
            SDTPanel = new Panel();
            SDTLabel = new Label();
            SDTBox = new TextBox();
            SOTCTLPanel = new Panel();
            SOTCTLLabel = new Label();
            SOTCTLBox = new TextBox();
            NgaySinhPanel = new Panel();
            NgaySinhLabel = new Label();
            NgaySinhBox = new TextBox();
            MaNganhPanel = new Panel();
            MaNganhLabel = new Label();
            MaNganhBox = new TextBox();
            MACTPanel = new Panel();
            MACTLabel = new Label();
            MACTBox = new TextBox();
            DiaChiPanel = new Panel();
            DiaChiLabel = new Label();
            DiaChiBox = new TextBox();
            HoTenPanel = new Panel();
            HoTenLabel = new Label();
            HoTenBox = new TextBox();
            PhaiPanel = new Panel();
            PhaiLabel = new Label();
            PhaiBox = new TextBox();
            MASVPanel = new Panel();
            MASVLabel = new Label();
            MASVBox = new TextBox();
            formLabel = new Label();
            MainPanel.SuspendLayout();
            DTBTLPanel.SuspendLayout();
            SDTPanel.SuspendLayout();
            SOTCTLPanel.SuspendLayout();
            NgaySinhPanel.SuspendLayout();
            MaNganhPanel.SuspendLayout();
            MACTPanel.SuspendLayout();
            DiaChiPanel.SuspendLayout();
            HoTenPanel.SuspendLayout();
            PhaiPanel.SuspendLayout();
            MASVPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MainPanel.BackColor = Color.FromArgb(224, 224, 224);
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DTBTLPanel);
            MainPanel.Controls.Add(SDTPanel);
            MainPanel.Controls.Add(SOTCTLPanel);
            MainPanel.Controls.Add(NgaySinhPanel);
            MainPanel.Controls.Add(MaNganhPanel);
            MainPanel.Controls.Add(MACTPanel);
            MainPanel.Controls.Add(DiaChiPanel);
            MainPanel.Controls.Add(HoTenPanel);
            MainPanel.Controls.Add(PhaiPanel);
            MainPanel.Controls.Add(MASVPanel);
            MainPanel.Location = new Point(12, 72);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1267, 480);
            MainPanel.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom;
            UpdateBtn.BackColor = Color.White;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(541, 398);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(114, 36);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Cập Nhật";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DTBTLPanel
            // 
            DTBTLPanel.Controls.Add(DTBTLLabel);
            DTBTLPanel.Controls.Add(DTBTLBox);
            DTBTLPanel.Font = new Font("Segoe UI", 12F);
            DTBTLPanel.Location = new Point(580, 303);
            DTBTLPanel.Name = "DTBTLPanel";
            DTBTLPanel.Size = new Size(349, 69);
            DTBTLPanel.TabIndex = 6;
            // 
            // DTBTLLabel
            // 
            DTBTLLabel.AutoSize = true;
            DTBTLLabel.Location = new Point(3, 18);
            DTBTLLabel.Name = "DTBTLLabel";
            DTBTLLabel.Size = new Size(230, 28);
            DTBTLLabel.TabIndex = 1;
            DTBTLLabel.Text = "Điểm Trung Bình Tích Luỹ";
            // 
            // DTBTLBox
            // 
            DTBTLBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DTBTLBox.BackColor = SystemColors.Control;
            DTBTLBox.Font = new Font("Segoe UI", 12F);
            DTBTLBox.Location = new Point(239, 15);
            DTBTLBox.Name = "DTBTLBox";
            DTBTLBox.ReadOnly = true;
            DTBTLBox.Size = new Size(107, 34);
            DTBTLBox.TabIndex = 8;
            // 
            // SDTPanel
            // 
            SDTPanel.Controls.Add(SDTLabel);
            SDTPanel.Controls.Add(SDTBox);
            SDTPanel.Font = new Font("Segoe UI", 12F);
            SDTPanel.Location = new Point(696, 78);
            SDTPanel.Name = "SDTPanel";
            SDTPanel.Size = new Size(309, 69);
            SDTPanel.TabIndex = 4;
            // 
            // SDTLabel
            // 
            SDTLabel.AutoSize = true;
            SDTLabel.Location = new Point(3, 18);
            SDTLabel.Name = "SDTLabel";
            SDTLabel.Size = new Size(133, 28);
            SDTLabel.TabIndex = 1;
            SDTLabel.Text = "Số Điện Thoại";
            // 
            // SDTBox
            // 
            SDTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            SDTBox.Font = new Font("Segoe UI", 12F);
            SDTBox.Location = new Point(142, 15);
            SDTBox.MaxLength = 10;
            SDTBox.Name = "SDTBox";
            SDTBox.Size = new Size(164, 34);
            SDTBox.TabIndex = 1;
            SDTBox.KeyPress += SDTBox_KeyPress;
            // 
            // SOTCTLPanel
            // 
            SOTCTLPanel.Controls.Add(SOTCTLLabel);
            SOTCTLPanel.Controls.Add(SOTCTLBox);
            SOTCTLPanel.Font = new Font("Segoe UI", 12F);
            SOTCTLPanel.Location = new Point(263, 303);
            SOTCTLPanel.Name = "SOTCTLPanel";
            SOTCTLPanel.Size = new Size(294, 69);
            SOTCTLPanel.TabIndex = 5;
            // 
            // SOTCTLLabel
            // 
            SOTCTLLabel.AutoSize = true;
            SOTCTLLabel.Location = new Point(3, 18);
            SOTCTLLabel.Name = "SOTCTLLabel";
            SOTCTLLabel.Size = new Size(174, 28);
            SOTCTLLabel.TabIndex = 1;
            SOTCTLLabel.Text = "Số Tín Chỉ Tích Luỹ";
            // 
            // SOTCTLBox
            // 
            SOTCTLBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            SOTCTLBox.BackColor = SystemColors.Control;
            SOTCTLBox.Font = new Font("Segoe UI", 12F);
            SOTCTLBox.Location = new Point(183, 15);
            SOTCTLBox.Name = "SOTCTLBox";
            SOTCTLBox.ReadOnly = true;
            SOTCTLBox.Size = new Size(108, 34);
            SOTCTLBox.TabIndex = 1;
            // 
            // NgaySinhPanel
            // 
            NgaySinhPanel.Controls.Add(NgaySinhLabel);
            NgaySinhPanel.Controls.Add(NgaySinhBox);
            NgaySinhPanel.Font = new Font("Segoe UI", 12F);
            NgaySinhPanel.Location = new Point(430, 78);
            NgaySinhPanel.Name = "NgaySinhPanel";
            NgaySinhPanel.Size = new Size(244, 69);
            NgaySinhPanel.TabIndex = 4;
            // 
            // NgaySinhLabel
            // 
            NgaySinhLabel.AutoSize = true;
            NgaySinhLabel.Location = new Point(3, 18);
            NgaySinhLabel.Name = "NgaySinhLabel";
            NgaySinhLabel.Size = new Size(102, 28);
            NgaySinhLabel.TabIndex = 1;
            NgaySinhLabel.Text = "Ngày Sinh";
            // 
            // NgaySinhBox
            // 
            NgaySinhBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            NgaySinhBox.BackColor = SystemColors.Control;
            NgaySinhBox.Font = new Font("Segoe UI", 12F);
            NgaySinhBox.Location = new Point(111, 15);
            NgaySinhBox.Name = "NgaySinhBox";
            NgaySinhBox.ReadOnly = true;
            NgaySinhBox.Size = new Size(130, 34);
            NgaySinhBox.TabIndex = 1;
            // 
            // MaNganhPanel
            // 
            MaNganhPanel.Controls.Add(MaNganhLabel);
            MaNganhPanel.Controls.Add(MaNganhBox);
            MaNganhPanel.Font = new Font("Segoe UI", 12F);
            MaNganhPanel.Location = new Point(638, 228);
            MaNganhPanel.Name = "MaNganhPanel";
            MaNganhPanel.Size = new Size(367, 69);
            MaNganhPanel.TabIndex = 4;
            // 
            // MaNganhLabel
            // 
            MaNganhLabel.AutoSize = true;
            MaNganhLabel.Location = new Point(3, 18);
            MaNganhLabel.Name = "MaNganhLabel";
            MaNganhLabel.Size = new Size(104, 28);
            MaNganhLabel.TabIndex = 1;
            MaNganhLabel.Text = "Mã Ngành";
            // 
            // MaNganhBox
            // 
            MaNganhBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            MaNganhBox.BackColor = SystemColors.Control;
            MaNganhBox.Font = new Font("Segoe UI", 12F);
            MaNganhBox.Location = new Point(112, 15);
            MaNganhBox.Name = "MaNganhBox";
            MaNganhBox.ReadOnly = true;
            MaNganhBox.Size = new Size(252, 34);
            MaNganhBox.TabIndex = 1;
            // 
            // MACTPanel
            // 
            MACTPanel.Controls.Add(MACTLabel);
            MACTPanel.Controls.Add(MACTBox);
            MACTPanel.Font = new Font("Segoe UI", 12F);
            MACTPanel.Location = new Point(263, 228);
            MACTPanel.Name = "MACTPanel";
            MACTPanel.Size = new Size(351, 69);
            MACTPanel.TabIndex = 5;
            // 
            // MACTLabel
            // 
            MACTLabel.AutoSize = true;
            MACTLabel.Location = new Point(3, 18);
            MACTLabel.Name = "MACTLabel";
            MACTLabel.Size = new Size(162, 28);
            MACTLabel.TabIndex = 1;
            MACTLabel.Text = "Mã Chương Trình";
            // 
            // MACTBox
            // 
            MACTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            MACTBox.BackColor = SystemColors.Control;
            MACTBox.Font = new Font("Segoe UI", 12F);
            MACTBox.Location = new Point(162, 15);
            MACTBox.Name = "MACTBox";
            MACTBox.ReadOnly = true;
            MACTBox.Size = new Size(186, 34);
            MACTBox.TabIndex = 1;
            // 
            // DiaChiPanel
            // 
            DiaChiPanel.Controls.Add(DiaChiLabel);
            DiaChiPanel.Controls.Add(DiaChiBox);
            DiaChiPanel.Font = new Font("Segoe UI", 12F);
            DiaChiPanel.Location = new Point(263, 153);
            DiaChiPanel.Name = "DiaChiPanel";
            DiaChiPanel.Size = new Size(742, 69);
            DiaChiPanel.TabIndex = 4;
            // 
            // DiaChiLabel
            // 
            DiaChiLabel.AutoSize = true;
            DiaChiLabel.Location = new Point(3, 18);
            DiaChiLabel.Name = "DiaChiLabel";
            DiaChiLabel.Size = new Size(74, 28);
            DiaChiLabel.TabIndex = 1;
            DiaChiLabel.Text = "Địa Chỉ";
            // 
            // DiaChiBox
            // 
            DiaChiBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DiaChiBox.BackColor = SystemColors.Control;
            DiaChiBox.Font = new Font("Segoe UI", 12F);
            DiaChiBox.Location = new Point(83, 15);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.ReadOnly = true;
            DiaChiBox.Size = new Size(656, 34);
            DiaChiBox.TabIndex = 1;
            // 
            // HoTenPanel
            // 
            HoTenPanel.Controls.Add(HoTenLabel);
            HoTenPanel.Controls.Add(HoTenBox);
            HoTenPanel.Font = new Font("Segoe UI", 12F);
            HoTenPanel.Location = new Point(580, 3);
            HoTenPanel.Name = "HoTenPanel";
            HoTenPanel.Size = new Size(425, 69);
            HoTenPanel.TabIndex = 2;
            // 
            // HoTenLabel
            // 
            HoTenLabel.AutoSize = true;
            HoTenLabel.Location = new Point(3, 18);
            HoTenLabel.Name = "HoTenLabel";
            HoTenLabel.Size = new Size(72, 28);
            HoTenLabel.TabIndex = 1;
            HoTenLabel.Text = "Họ Tên";
            // 
            // HoTenBox
            // 
            HoTenBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            HoTenBox.BackColor = SystemColors.Control;
            HoTenBox.Font = new Font("Segoe UI", 12F);
            HoTenBox.Location = new Point(81, 15);
            HoTenBox.Name = "HoTenBox";
            HoTenBox.ReadOnly = true;
            HoTenBox.Size = new Size(341, 34);
            HoTenBox.TabIndex = 1;
            // 
            // PhaiPanel
            // 
            PhaiPanel.Controls.Add(PhaiLabel);
            PhaiPanel.Controls.Add(PhaiBox);
            PhaiPanel.Font = new Font("Segoe UI", 12F);
            PhaiPanel.Location = new Point(263, 78);
            PhaiPanel.Name = "PhaiPanel";
            PhaiPanel.Size = new Size(146, 69);
            PhaiPanel.TabIndex = 3;
            // 
            // PhaiLabel
            // 
            PhaiLabel.AutoSize = true;
            PhaiLabel.Location = new Point(3, 18);
            PhaiLabel.Name = "PhaiLabel";
            PhaiLabel.Size = new Size(49, 28);
            PhaiLabel.TabIndex = 1;
            PhaiLabel.Text = "Phái";
            // 
            // PhaiBox
            // 
            PhaiBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PhaiBox.BackColor = SystemColors.Control;
            PhaiBox.Font = new Font("Segoe UI", 12F);
            PhaiBox.Location = new Point(58, 15);
            PhaiBox.Name = "PhaiBox";
            PhaiBox.ReadOnly = true;
            PhaiBox.Size = new Size(85, 34);
            PhaiBox.TabIndex = 1;
            // 
            // MASVPanel
            // 
            MASVPanel.Controls.Add(MASVLabel);
            MASVPanel.Controls.Add(MASVBox);
            MASVPanel.Font = new Font("Segoe UI", 12F);
            MASVPanel.Location = new Point(263, 3);
            MASVPanel.Name = "MASVPanel";
            MASVPanel.Size = new Size(297, 69);
            MASVPanel.TabIndex = 0;
            // 
            // MASVLabel
            // 
            MASVLabel.AutoSize = true;
            MASVLabel.Location = new Point(3, 18);
            MASVLabel.Name = "MASVLabel";
            MASVLabel.Size = new Size(126, 28);
            MASVLabel.TabIndex = 1;
            MASVLabel.Text = "Mã Sinh Viên";
            // 
            // MASVBox
            // 
            MASVBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            MASVBox.BackColor = SystemColors.Control;
            MASVBox.Font = new Font("Segoe UI", 12F);
            MASVBox.Location = new Point(135, 15);
            MASVBox.Name = "MASVBox";
            MASVBox.ReadOnly = true;
            MASVBox.Size = new Size(159, 34);
            MASVBox.TabIndex = 1;
            // 
            // formLabel
            // 
            formLabel.Anchor = AnchorStyles.Top;
            formLabel.AutoSize = true;
            formLabel.FlatStyle = FlatStyle.Flat;
            formLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formLabel.Location = new Point(460, 9);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(326, 46);
            formLabel.TabIndex = 1;
            formLabel.Text = "Thông Tin Cá Nhân";
            // 
            // SV_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 588);
            Controls.Add(formLabel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SV_Profile";
            Text = "ProfileSVForm";
            MainPanel.ResumeLayout(false);
            DTBTLPanel.ResumeLayout(false);
            DTBTLPanel.PerformLayout();
            SDTPanel.ResumeLayout(false);
            SDTPanel.PerformLayout();
            SOTCTLPanel.ResumeLayout(false);
            SOTCTLPanel.PerformLayout();
            NgaySinhPanel.ResumeLayout(false);
            NgaySinhPanel.PerformLayout();
            MaNganhPanel.ResumeLayout(false);
            MaNganhPanel.PerformLayout();
            MACTPanel.ResumeLayout(false);
            MACTPanel.PerformLayout();
            DiaChiPanel.ResumeLayout(false);
            DiaChiPanel.PerformLayout();
            HoTenPanel.ResumeLayout(false);
            HoTenPanel.PerformLayout();
            PhaiPanel.ResumeLayout(false);
            PhaiPanel.PerformLayout();
            MASVPanel.ResumeLayout(false);
            MASVPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private Panel MASVPanel;
        private TextBox MASVBox;
        private Label MASVLabel;
        private Panel SDTPanel;
        private Label SDTLabel;
        private TextBox MaNganhBox;
        private Panel NgaySinhPanel;
        private Label NgaySinhLabel;
        private TextBox PhaiBox;
        private Panel MaNganhPanel;
        private Label MaNganhLabel;
        private TextBox MACTBox;
        private Panel MACTPanel;
        private Label MACTLabel;
        private TextBox DiaChiBox;
        private Panel DiaChiPanel;
        private Label DiaChiLabel;
        private TextBox SDTBox;
        private Panel HoTenPanel;
        private Label HoTenLabel;
        private TextBox HoTenBox;
        private Panel PhaiPanel;
        private Label PhaiLabel;
        private TextBox NgaySinhBox;
        private Panel DTBTLPanel;
        private Label DTBTLLabel;
        private TextBox SOTCTLBox;
        private Panel SOTCTLPanel;
        private Label SOTCTLLabel;
        private TextBox DTBTLBox;
        private Button UpdateBtn;
        private Label formLabel;
    }
}