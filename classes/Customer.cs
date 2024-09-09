using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje_ef.classes
{
    public class Customer
    {
        
        public int customerId { get; set; }
        public string customername { get; set; }
        public string customersurname { get; set; }
        public string customertc { get; set; }
        public string customertel { get; set; }
        public string customerstate { get; set; }
        public string email { get; set; }

        //FK tanımlamaları
        public int staffId { get; set; }
        public int unitId { get; set; }

        //İlişkiler
        public Staff staff { get; set; }
        public Unit unit { get; set; }
        
    }
}
