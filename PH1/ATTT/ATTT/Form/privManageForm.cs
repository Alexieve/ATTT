using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT
{
    public partial class privManageForm : Form
    {
        private Form activeForm = null;
        private Button currentButton;
        public privManageForm()
        {
            InitializeComponent();
        }

        private void GrantPrivButton_Click(object sender, EventArgs e)
        {
            openChildForm(new GrantPrivForm());
            ActiveButton(sender);

        }

        private void GrantPrivColButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void GrantRoleButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }
        
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(128, 128, 128);
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(224, 224, 224);
            }
        }
    }
}
