using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using staj_proje_ef.classes;


namespace staj_proje_ef.classes
{
    public class Role
    {
        public int roleId { get; set; }
        public string rolename { get; set; }

        //İlişkiler
        public ICollection<Staff> staffs { get; set; }


    }
}
