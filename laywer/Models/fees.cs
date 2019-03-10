using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class fees
    {
        public int ID { get; set; }
        [DisplayName("رقم القضيه")]

        public int NumberOfCase { get; set; }
        [DisplayName("رقم الموكل")]

        public Client clientID { get; set; }
        [DisplayName("مجكل الاتعاب")]

        public int totalFees { get; set; }
        [DisplayName("باقى من الاتعاب")]

        public int finallFees { get; set; }
        [DisplayName("دفعه جديده")]

        public int recived { get; set; }
        [DisplayName("تاريخ الدفعه")]

        public DateTime DateofRevice { get; set; }
        [DisplayName("ملاحظات")]

        public string notes { get; set; }

    }
}