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
        Staff model = null;

        public addstaff()
        {
            InitializeComponent();
        }
        public addstaff(Staff _model)
        {
            InitializeComponent();
            this.model = _model;
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
        async void AddData()
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
            AddData();

        }

        private void addemp_Load(object sender, EventArgs e)
        {
            FillComboBox();

            if (model != null) {

                unitBox.DataSource = null;
                unitBox.Items.Clear();
                tcTxtBox.Visible = false;
                usernameTxt.Visible = false;
                passwordTxt.Visible = false;
                TcLbl.Visible = false;
                usernameLbl.Visible = false;
                passwordLbl.Visible = false;


                nameTxtBox.Text = model.staffname;
                surnameTxtBox.Text = model.staffsurname;
                telTxtBox.Text = model.stafftel;
                addressTxtBox.Text = model.address;

                //unitBox.Text = model.;
                
                //jobBox.Text = model.job.jobname;
                //roleBox.Text = model.role.rolename;
            }


        }

        private void unitBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //jobBox.Items.Clear();
            //var unitcustomers = db.customers.Where(c => c.customerstate == "Aktif Müşteri" && c.unitId == LoginPage.suId).ToList();
           

            //var jbox = from a in db.jobs
            //           join b in db.units
            //           on a.unitId equals b.unitId  where (a.unitId == deger) select a;
                  
           


        }
    }
}
