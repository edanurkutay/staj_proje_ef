using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje_ef
{
    public partial class ProfilePage : Form
    {
        private Button currentButton;
        private Form activeForm;
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.SteelBlue;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Azure;
                    currentButton.Font = new Font("Segoe Print", 11F);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in btnPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Lavender;
                    previousBtn.ForeColor = Color.Navy;
                    previousBtn.Font = new Font("Segoe Print", 9F);

                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm !=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pageNameLabel.Text = childForm.Text;

        }

        private void Labeltext()
        {
            //Forms.view.tableNameLabel.Text = "s";

        }

        private void viewStaffBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.viewperson(), sender);
        }

        private void viewCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.viewperson(), sender);
        }

        private void acceptCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.viewperson(), sender);
        }

        private void addCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.addcus(), sender);
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.addemp(), sender);
        }

  

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }

}
