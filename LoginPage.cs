using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Win32;
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
    public partial class LoginPage : Form
    {
        CompanySystemContext context = new();


        public LoginPage()
        {
            InitializeComponent();
        }

        public static string staffrole;
        public static string staffunit;
        public static int sId;
        public static int suId;
        public static string sTC;
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await context.staffs.Include(s => s.unit).Include(r => r.role).Include(j => j.job).SingleOrDefaultAsync(u => u.username == userNameTxtbox.Text && u.password == passwordTxtbox.Text);

                if (user != null)
                {
                    ProfilePage profilePage = new ProfilePage();
                    profilePage.nameLabel.Text = user.staffname + " " + user.staffsurname;
                    staffrole = user.role.rolename;
                    staffunit = user.unit.unitname;
                    sId = user.staffId;
                    suId = user.unitId;
                    sTC = user.stafftc;
                    profilePage.roleLabel.Text = staffrole;
                    profilePage.unitLabel.Text = staffunit;
                    profilePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordShow.Checked == true)
            {
                passwordTxtbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxtbox.UseSystemPasswordChar = true;
            }
        }
    }
}

