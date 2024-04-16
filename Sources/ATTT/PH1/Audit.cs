using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1
{
    public partial class Audit : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public Audit()
        {
            InitializeComponent();
            AuditViewBtn_Click(AuditViewBtn, null);
        }
        private void AuditViewBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Audit_View());
            ActiveButton(sender);
        }
        private void FGABtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Audit_ViewFGA());
            ActiveButton(sender);
        }
        private void UserAuditBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Audit_Statement());
            ActiveButton(sender);
        }

        private void ObjectAuditBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Audit_Object());
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
                    currentButton.BackColor = SystemColors.GradientActiveCaption;
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                // set color GradientInactiveCaption
                currentButton.BackColor = SystemColors.GradientInactiveCaption;
            }
        }
    }
}
