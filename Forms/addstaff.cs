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
using System.Net;

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

                //var jobList = db.jobs.ToList();
                //

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

        private void addstaff_Load(object sender, EventArgs e)
        {
            FillComboBox();

            if (model != null)
            {

                empRegistBtn.Visible = false;
                updateBtn.Visible = true;


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


                unitBox.SelectedValue = model.unitId;

                unitBox_SelectionChangeCommitted(null, null);
                jobBox.SelectedValue = model.jobId;
                roleBox.SelectedValue = model.roleId;


            }
            else
            {
                unitBox.SelectedIndex = -1;
            }

        }

        private void unitBox_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = null;
            if (unitBox.SelectedValue.GetType() == typeof(int))
            {
                b = unitBox.SelectedValue;
            }
            else
            {
                Unit a = (Unit)unitBox.SelectedValue;
                b = a.unitId;
            }


            var juInfo = db.jobInfos.Where(j => j.unitId == Convert.ToInt32(b));
            jobBox.DataSource = juInfo.ToList();
            jobBox.DisplayMember = "jobname";
            jobBox.ValueMember = "unitId";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (model != null)
            {
                int s = model.staffId;

                Staff updateStaff = db.staffs.Find(s);
                updateStaff.staffname = nameTxtBox.Text;
                updateStaff.staffsurname = surnameTxtBox.Text;
                updateStaff.stafftel = telTxtBox.Text;
                updateStaff.address = addressTxtBox.Text;
                updateStaff.unitId = (int)unitBox.SelectedValue;
                updateStaff.jobId = (int)jobBox.SelectedValue;
                updateStaff.roleId = (int)roleBox.SelectedValue;
                db.SaveChanges();
            }
        }

        private void unitBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (unitBox.SelectedValue == null)
                return;

            int b = (int)unitBox.SelectedValue;


            var juInfo = db.jobInfos.Where(j => j.unitId == b);
            jobBox.DataSource = juInfo.ToList();
            jobBox.DisplayMember = "jobname";
            jobBox.ValueMember = "jobId";

        }
    }
}
