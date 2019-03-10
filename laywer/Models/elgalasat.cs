using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class elgalasat
    {
        public int id { get; set; }
        [DisplayName("رقم الجلسه")]

        public int NumberOfGalsa { get; set; }
        [DisplayName("رقم القضيه")]

        public int NumberOfCase { get; set; }
        [DisplayName("تاريخ الجلسه")]

        public DateTime dateOfGalsa { get; set; }
        [DisplayName("رقم الرول")]


        public string RollNumber { get; set; }
        [DisplayName("المحكمه")]

        public int Court { get; set; }
        [DisplayName("الدائره")]

        public string eldarea { get; set; }
        [DisplayName("القرار")]


        public string desicion { get; set; }
        [DisplayName("الطلبات")]


        public string orders { get; set; }

    }
}