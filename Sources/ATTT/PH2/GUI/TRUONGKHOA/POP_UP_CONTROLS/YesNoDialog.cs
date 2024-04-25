using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2.GUI.TRUONGKHOA.POP_UP_CONTROLS
{
    public partial class YesNoDialog : UserControl
    {
        public string PromptText
        {
            get { return labelPrompt.Text; }
            set { labelPrompt.Text = value; }
        }

        public DialogResult DialogResult { get; private set; }

        public YesNoDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog()
        {
            DialogResult = DialogResult.None;
            Form form = new Form();
            form.FormBorderStyle = FormBorderStyle.FixedSingle; // Set the border style to FixedSingle
            form.ClientSize = new Size(441, 192);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Controls.Add(this);
            form.FormClosing += (sender, e) =>
            {
                if (DialogResult == DialogResult.None)
                    DialogResult = DialogResult.No;
            };
            form.ShowDialog();
            return DialogResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            ParentForm.DialogResult = DialogResult;
            ParentForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            ParentForm.DialogResult = DialogResult;
            ParentForm.Close();
        }
    }
}
