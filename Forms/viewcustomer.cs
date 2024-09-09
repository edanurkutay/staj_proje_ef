using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
    public partial class viewcustomer : Form
    {
        public viewcustomer()
        {
            InitializeComponent();
        }
        CompanySystemContext db = new CompanySystemContext();

        public void FillTable()
        {

            //1 Tüm Aktif Müşteriler Listelenecek -Admin
            //2 Birimlerdeki Aktif Müşteriler Listelenecek -BY
            //3 Birimlerdeki Pasif Müşteriler listelenecek -BY
            //4 Birim Yöneticisi onayından geçmiş müşterlier listelenecek -Admin
            //5 Personel özeli müşteriler listelenecek -Personel




            if (LoginPage.staffrole == "Admin")
            {
                //1

                var allcustomers1 = db.customerInfos.Where(c => c.KayıtDurumu == "Aktif Müşteri").ToList();
                DataTable dt = new DataTable();
                dataGridVCustomer.DataSource = allcustomers1;
            }

            else if (LoginPage.staffrole == "Birim Yöneticisi")
            {
                //2
                var unitcustomers = db.customerInfos.Where(c => c.KayıtDurumu == "Aktif Müşteri" && c.KayıtBirimi == LoginPage.staffunit).ToList();
                DataTable dt1 = new DataTable();
                dataGridVCustomer.DataSource = unitcustomers;
            }
            else if (LoginPage.staffrole == "Personel")
            {
                //5
                var staffcustomers = db.customerInfos.Where(c => c.PersonelNo == LoginPage.sId).ToList();
                DataTable dt4 = new DataTable();
                dataGridVCustomer.DataSource = staffcustomers;

            }
        }

        private void viewcustomer_Load(object sender, EventArgs e)
        {
            FillTable();

            if (LoginPage.staffrole == "Personel")
            {
                deleteCusBtn.Visible= false;
            }
        }

        public static int selectedId;

        private async void deleteCusBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = new DialogResult();

            selectedId = Convert.ToInt32(dataGridVCustomer.CurrentRow.Cells["Müşteri No"].Value);

            result = MessageBox.Show(selectedId+ " Numaralı Müşteri Silinsin mi?", "Müşteri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Customer delcus = await db.customers.FindAsync(selectedId);
                delcus.customerstate = "Pasif Müşteri";
                db.SaveChanges();

            }


        }
    }
}
