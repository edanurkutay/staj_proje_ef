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
    public partial class viewperson : Form
    {
        public viewperson()
        {
            InitializeComponent();
        }
        CompanySystemContext db = new CompanySystemContext();

        private async void ViewStaff()
        {
            var staffTable = db.staffs.ToList();

        }



        private void viewperson_Load(object sender, EventArgs e)
        {

        }
    }
}
