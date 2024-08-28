using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje_ef.classes
{
    public class Unit
    {
        public int unitId { get; set; }
        public string unitname { get; set; }

        //İlişkiler
        public ICollection<Staff> staffs { get; set; } 
        public ICollection<Customer> customers { get; set; }
        public ICollection<Job>jobs { get; set; }
    }
}
