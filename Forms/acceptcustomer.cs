using staj_proje_ef.classes;
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
        CompanySystemContext db = new CompanySystemContext();

        public void FillTable1()
        {

            //1 Tüm Aktif Müşteriler Listelenecek - Admin
            //2 Birimlerdeki Aktif Müşteriler Listelenecek - BY
            //3 Birimlerdeki Pasif Müşteriler listelenecek - BY
            //4 Birim Yöneticisi onayından geçmiş müşterlier listelenecek - Admin
            //5 Personel özeli müşteriler listelenecek - Personel



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
                var unitcustomers = db.customerInfos.Where(c => c.KayıtDurumu == "Pasif Müşteri" && c.KayıtBirimi == LoginPage.staffunit).ToList();
                DataTable dt1 = new DataTable();
                dataGridACustomer.DataSource = unitcustomers;
            }
        }


        private void acceptcustomer_Load(object sender, EventArgs e)
        {
            FillTable1();
        }

        private async void acceptCusBtn_Click(object sender, EventArgs e)
        {
            int selectedId;
            DialogResult result = new DialogResult();

            selectedId = Convert.ToInt32(dataGridACustomer.CurrentRow.Cells["MüşteriNo"].Value);

            result = MessageBox.Show(selectedId + " Numaralı Müşteri Eklensin mi?", "Müşteri Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Customer acptcus = await db.customers.FindAsync(selectedId);

                if (LoginPage.staffrole=="Birim Yöneticisi")
                {
                    acptcus.customerstate = "Onaydan Geçti";
                }
                else if(LoginPage.staffrole =="Admin")
                {
                    acptcus.customerstate = "Aktif Müşteri";

                }
            }
            else
            {

            }
        }

        private void deleteCusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
