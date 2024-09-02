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
    public partial class acceptcustomer : Form
    {
        public acceptcustomer()
        {
            InitializeComponent();
        }

        public void FillTable1()
        {

            //1 Tüm Aktif Müşteriler Listelenecek - Admin
            //2 Birimlerdeki Aktif Müşteriler Listelenecek - BY
            //3 Birimlerdeki Pasif Müşteriler listelenecek - BY
            //4 Birim Yöneticisi onayından geçmiş müşterlier listelenecek - Admin
            //5 Personel özeli müşteriler listelenecek - Personel

            CompanySystemContext db = new CompanySystemContext();


            if (LoginPage.staffrole == "Admin")
            {
                //4
                var allcustomers = db.customerInfos.Where(c => c.KayıtDurumu == "Onaydan Geçti").ToList();
                DataTable dt = new DataTable();
                dataGridACustomer.DataSource = allcustomers;
            }

            else if (LoginPage.staffrole == "Birim Yöneticisi")
            {
                //3
                var unitcustomers = db.customerInfos.Where(c => c.KayıtDurumu == "Pasif Müşteri" && c.TC == LoginPage.sTC).ToList();
                DataTable dt1 = new DataTable();
                dataGridACustomer.DataSource = unitcustomers;
            }
        }


        private void acceptcustomer_Load(object sender, EventArgs e)
        {
            FillTable1();
        }

        private void acceptCusBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteCusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
