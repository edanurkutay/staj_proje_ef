using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje_ef.classes
{
    public class Job
    {

        public int jobId { get; set; }
        public string jobname { get; set; }

        //FK tanımlamaları
        public int unitId { get;set; }

        //İlişkiler
        public ICollection<Staff> staffs { get; set; }
        public Unit unit { get; set; }
      

    }
}
