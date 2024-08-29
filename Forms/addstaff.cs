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
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using Azure.Core.Serialization;

namespace staj_proje_ef.Forms
{
    public partial class addstaff : Form
    {
        public addstaff()
        {
            InitializeComponent();
        }

        private CompanySystemContext db = new CompanySystemContext();
        async void FillComboBox()
        {
            try
            {
                var unitList = db.units.ToList();
                unitBox.DataSource = unitList;
                unitBox.DisplayMember = "unitname";
                unitBox.ValueMember = "unitId";

                var jobList = db.jobs.ToList();
                jobBox.DataSource = jobList.ToList();
                jobBox.DisplayMember = "jobname";
                jobBox.ValueMember = "jobId";

                var roleList = db.roles.ToList();
                roleBox.DataSource = roleList;
                roleBox.DisplayMember = "rolename";
                roleBox.ValueMember = "roleId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        async void AddStaff()
        {
            try
            {
                Staff staff = new()
                {
                    staffname = nameTxtBox.Text,
                    staffsurname = surnameTxtBox.Text,
                    stafftel = telTxtBox.Text,
                    stafftc = tcTxtBox.Text,
                    address = addressTxtBox.Text,
                    username = usernameTxt.Text,
                    password = passwordTxt.Text,
                    unitId = (int)unitBox.SelectedValue,
                    jobId = (int)jobBox.SelectedValue,
                    roleId = (int)roleBox.SelectedValue

                };
                await db.AddAsync(staff);
                await db.SaveChangesAsync();

                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void empRegistBtn_Click(object sender, EventArgs e)
        {
            AddStaff();

        }

        private void addemp_Load(object sender, EventArgs e)
        {
            FillComboBox();


        }

        private void unitBox_SelectedValueChanged(object sender, EventArgs e)
        {

    

        }
    }
}
