﻿using Microsoft.IdentityModel.Tokens;
using staj_proje_ef.classes;
using staj_proje_ef.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace staj_proje_ef.Forms
{
    public partial class viewstaff : Form
    {
        addstaff frm1;
        ProfilePage parentForm;
        public viewstaff(addstaff _updatestf)
        {
            InitializeComponent();
            this.frm1 = _updatestf;
        }



        CompanySystemContext db = new CompanySystemContext();


        private async void viewperson_Load(object sender, EventArgs e)
        {

            if (LoginPage.staffrole == "Admin")
            {
                var stafflst = db.staffInfos.ToList();
                DataTable dt = new DataTable();
                dataGridStaff.DataSource = stafflst;
            }
            else if (LoginPage.staffrole == "Birim Yöneticisi")
            {
                var stafflst1 = db.staffInfos
                    .Where(us => us.Birim == LoginPage.staffunit).ToList();
                DataTable dt = new DataTable();
                dataGridStaff.DataSource = stafflst1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedId;
            DialogResult result = new DialogResult();

            selectedId = Convert.ToInt32(dataGridStaff.CurrentRow.Cells["PersonelNo"].Value);

            result = MessageBox.Show(selectedId + " Numaralı Personel Bilgileri Güncellensin mi?", "Personel Bilgisi Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                var frm = (ProfilePage)this.Parent.Parent;
                

                if ((frm != null))
                {
                   

                    Staff updatestaff = await db.staffs.FindAsync(selectedId);

                    frm.OpenChildForm(new addstaff(updatestaff), sender);

                }

            }
        }

        private void dataGridStaff_SelectionChanged(object sender, EventArgs e)
        {



        }
    }
}
