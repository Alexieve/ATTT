using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Connection.Connect("C##ADMIN", "Atlas2003.");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Connection.username;
        }

        private void listUserPanel_Click(object sender, EventArgs e)
        {
            openChildForm(new userListForm());
            ActiveButton(sender);
        }

        private void CheckPrivPanel_Click(object sender, EventArgs e)
        {
            openChildForm(new checkPrivForm());
            ActiveButton(sender);

        }

        private void userManagePanel_Click(object sender, EventArgs e)
        {
            openChildForm(new userManageForm());
            ActiveButton(sender);

        }

        private void roleManagePanel_Click(object sender, EventArgs e)
        {
            openChildForm(new roleManageForm());
            ActiveButton(sender);

        }

        private void privManagePanel_Click(object sender, EventArgs e)
        {
            openChildForm(new privManageForm());
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Connection.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        // Active and Deactive button
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
