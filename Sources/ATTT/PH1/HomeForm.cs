using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PH1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATTT
{
    public partial class HomeForm : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public HomeForm()
        {
            InitializeComponent();
            //Connection.Connect("C##ADMIN", "123");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Connection.username;
        }

        private void listUserBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new userListForm());
            ActiveButton(sender);
        }

        private void CheckPrivBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new checkPrivForm());
            ActiveButton(sender);

        }

        private void userManageBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new userManageForm());
            ActiveButton(sender);

        }

        private void roleManageBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new roleManageForm());
            ActiveButton(sender);

        }

        private void privManageBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new privManageForm());
            ActiveButton(sender);

        }
        private void AuditBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Audit());
            ActiveButton(sender);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Connection.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
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
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
    }
}
