using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje_ef.Forms
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        CompanySystemContext db = new CompanySystemContext();
        private void RegistBtn_Click(object sender, EventArgs e)
        {
            var stf =  db.staffs.Find(LoginPage.sId);

            if (stf.password == oldPassTxt.Text) 
            {
                stf.password = newPassTxt.Text;
                db.SaveChanges();
            }
            else 
            {
                MessageBox.Show("Eski şifre yanlış");

            }


        }
    }
}
