using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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



            if (LoginPage.staffrole == "Admin")
            {
                //1
                
                var allcustomers1 = db.customerInfos.Where(c => c.KayıtDurumu == "Aktif Müşteri").ToList();
                DataTable dt = new DataTable();
                dataGridACustomer.DataSource = allcustomers1;
            }

            else if (LoginPage.staffrole == "Birim Yöneticisi")
            {
                //2
                var unitcustomers = db.customerInfos.Where(c => c.KayıtDurumu == "Aktif Müşteri" && c.KayıtBirimi == LoginPage.staffunit).ToList();
                DataTable dt1 = new DataTable();
                dataGridACustomer.DataSource = unitcustomers;
            }
            else if (LoginPage.staffrole == "Personel")
            {
                //5
                var staffcustomers = db.customerInfos.Where(c => c.TC == LoginPage.sTC).ToList();
                DataTable dt4 = new DataTable();
                dataGridACustomer.DataSource = staffcustomers;

            }
        }

        private void viewcustomer_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        public static int selectedId;

        private void deleteCusBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = new DialogResult();

            selectedId = Convert.ToInt32(dataGridACustomer.CurrentRow.Cells["customerId"].Value);

            result = MessageBox.Show(selectedId+ " Numaralı Müşteri Silinsin mi?", "Müşteri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

            }


        }
    }
}
