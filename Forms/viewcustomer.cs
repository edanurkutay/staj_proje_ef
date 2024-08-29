using Microsoft.EntityFrameworkCore;
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
    public partial class viewcustomer : Form
    {
        public viewcustomer()
        {
            InitializeComponent();
        }

        public void FillTable()
        {

            //1 Tüm Aktif Müşteriler Listelenecek - Admin
            //2 Birimlerdeki Aktif Müşteriler Listelenecek - BY
            //3 Birimlerdeki Pasif Müşteriler listelenecek - BY
            //4 Birim Yöneticisi onayından geçmiş müşterlier listelenecek - Admin
            //5 Personel özeli müşteriler listelenecek - Personel

            CompanySystemContext db = new CompanySystemContext();


            if(LoginPage.staffrole =="Admin")
            {
                //1
                var allcustomers = db.customers.Where(c => c.customerstate == "Aktif Müşteri").ToList();
                DataTable dt = new DataTable();
                dataGridACustomer.DataSource = allcustomers;
            }

            else if(LoginPage.staffrole == "Birim Yöneticisi")
            {
                //2
                var unitcustomers = db.customers.Where(c => c.customerstate == "Aktif Müşteri" && c.unitId == LoginPage.suId).ToList();
                DataTable dt1 = new DataTable();
                dataGridACustomer.DataSource = unitcustomers;
            }
            else if (LoginPage.staffrole == "Personel")
            {
                //5
                var staffcustomers = db.customers.Where(c => c.staffId == LoginPage.sId).ToList();
                DataTable dt4 = new DataTable();
                dataGridACustomer.DataSource = staffcustomers;

            }
        }

        private void viewcustomer_Load(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
