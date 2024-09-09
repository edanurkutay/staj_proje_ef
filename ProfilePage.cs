using Microsoft.Identity.Client;
using staj_proje_ef.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using  System.Runtime.InteropServices.JavaScript.JSType;

namespace staj_proje_ef
{
    public partial class ProfilePage : Form
    {
        public Button currentButton;
        public Form activeForm;


        public ProfilePage()
        {
            InitializeComponent();

        }
        viewstaff vp = new Forms.viewstaff(new addstaff());

        public void ActivateButton(object btnSender)
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
        public void DisableButton()
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
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
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
            pageNameLabel.Visible = true;
            pageNameLabel.Text = childForm.Text;
        }
        private void Authorization()
        {

            if (LoginPage.staffrole == "Admin")
            {
                addCusBtn.Visible = false;
                viewCusBtn.Size = new Size(225, 75);
                acceptCusBtn.Size = new Size(225, 75);
                acceptCusBtn.Location = new Point(225, -3);
                addStaffBtn.Size = new Size(225, 75);
                addStaffBtn.Location = new Point(450, -3);
                viewStaffBtn.Size = new Size(225, 75);
                viewStaffBtn.Location = new Point(675, -3);
            }
            else if (LoginPage.staffrole == "Birim Yöneticisi")
            {
                addStaffBtn.Visible = false;
                viewCusBtn.Size = new Size(225, 75);
                acceptCusBtn.Size = new Size(225, 75);
                acceptCusBtn.Location = new Point(225, -3);
                addCusBtn.Size = new Size(225, 75);
                addCusBtn.Location = new Point(450, -3);
                viewStaffBtn.Size = new Size(225, 75);
                viewStaffBtn.Location = new Point(675, -3);
            }
            else if (LoginPage.staffrole == "Personel")
            {
                addStaffBtn.Visible = false;
                viewStaffBtn.Visible = false;
                acceptCusBtn.Visible = false;

                viewCusBtn.Size = new Size(450, 75);
                addCusBtn.Size = new Size(450, 75);
                addCusBtn.Location = new Point(450, -3);
            }
        }

        private void viewStaffBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.viewstaff(new addstaff()), sender);
        }

        private void viewCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.viewcustomer(), sender);
        }

        private void acceptCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.acceptcustomer(), sender);
        }

        private void addCusBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.addcus(), sender);
        }
        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.addstaff(), sender);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
        private void ProfilePage_Load(object sender, EventArgs e)
        {
            Authorization();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings fm1 = new settings();
            fm1.TopLevel = false;
            fm1.FormBorderStyle = FormBorderStyle.None;
            fm1.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(fm1);
            this.mainPanel.Tag = fm1;
            fm1.BringToFront();
            fm1.Show();
            pageNameLabel.Visible = true;
            pageNameLabel.Text = fm1.Text;

        }
    }

}
