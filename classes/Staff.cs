using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using staj_proje_ef.classes;

namespace staj_proje_ef.classes
{
    public class Staff
    {

        public int staffId { get; set; }
        public string staffname { get; set; }
        public string staffsurname { get; set; }
        public string stafftel { get; set; }
        public string stafftc { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        //FK tanımlamaları
        public int unitId { get; set; }
        public int jobId { get; set; }
        public int roleId {  get; set; }

        //İlişkiler
        public Unit unit { get; set; }
        public Job job { get; set; }
        public ICollection<Customer>customers  { get; set; } 
        public Role role { get; set; }

    
    }
}
