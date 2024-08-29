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
        public viewstaff()
        {
            InitializeComponent();
        }
        CompanySystemContext db = new CompanySystemContext();


        private void viewperson_Load(object sender, EventArgs e)
        {
        }

        private void acceptCusBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
