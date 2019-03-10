using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class Agenda
    {
        public int id { get; set; }
        [DisplayName("رقم القضيه")]

        public int numberCase { get; set; }
        [DisplayName("رقم الملف")]

        public int FileNumber{ get; set; }
        [DisplayName("رقم الجلسه")]

        public DateTime DateOfGalas { get; set; }
        [DisplayName("اسم الموكل")]
 
        public string ClientName { get; set; }
        [DisplayName("نوع الموكل")]

        public string TypeOfClinet { get; set; }
        [DisplayName("اسم الخصم")]

        public string GuilityName { get; set; }
        [DisplayName("نوع الخصم")]

        public string TypeOfGuility { get; set; }


    }
}