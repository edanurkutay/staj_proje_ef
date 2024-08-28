using staj_proje_ef.classes;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje_ef.Forms
{
    public partial class addcus : Form
    {
        public addcus()
        {
            InitializeComponent();
        }
        CompanySystemContext db = new CompanySystemContext();

        private async void cusRegistBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                customername = nameBox.Text,
                customersurname = surnameBox.Text,
                customertel = telBox.Text,
                customertc = tcBox.Text,
                email = emailBox.Text,
                staffId = LoginPage.sId,
                unitId = LoginPage.suId,
                customerstate = "Pasif Müşteri"
            };
            await db.AddAsync(customer);
            await db.SaveChangesAsync();
        }
    }
}
