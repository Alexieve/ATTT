namespace PH2.GUI
{
    partial class DeTaiNC
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
            DeTaiNCTB = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DeTaiNCTB).BeginInit();
            SuspendLayout();
            // 
            // DeTaiNCTB
            // 
            DeTaiNCTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeTaiNCTB.Location = new Point(12, 12);
            DeTaiNCTB.Name = "DeTaiNCTB";
            DeTaiNCTB.RowHeadersWidth = 51;
            DeTaiNCTB.Size = new Size(1291, 628);
            DeTaiNCTB.TabIndex = 0;
            // 
            // DeTaiNC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 652);
            Controls.Add(DeTaiNCTB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeTaiNC";
            Text = "DeTaiNC";
            ((System.ComponentModel.ISupportInitialize)DeTaiNCTB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DeTaiNCTB;
    }
}