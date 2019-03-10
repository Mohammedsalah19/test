using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class Cases
    {
        public int id { get; set; }
        [DisplayName("رقم القضيه")]

        public int numberOfCase  { get; set; }
        [DisplayName("رقم الملف ")]

        public int numberOfFile { get; set; }
        [DisplayName("عنوان الموكل ")]


        public string  AddressofClient { get; set; }
        [DisplayName("نوع الموكل ")] //مدعى ام مدعى عليه

        public string TypeofClient { get; set; }
        [DisplayName(" رقم التوكيل")]

        public int NumberoOfTawkeel { get; set; }
        [DisplayName("نوع التوكيل")]

        public string TypeoOfTawkeel { get; set; }
        [DisplayName("درجه التقاضى")]

        public string degreeOfCase { get; set; }
        [DisplayName("تاريخ التوكيل")]

        public DateTime  dateofElkaeed { get; set; }
        [DisplayName("اسم الخصم")]
 
        public string nameofGuillty { get; set; }
        [DisplayName("عنوان الخصم")]
        public string AddressoFGuility { get; set; }
        [DisplayName("نوع الخصم")] // مدعى ام مدعى عليه

        public string TypeofGuility { get; set; }
        [DisplayName("اسم المحكمه")]

        public string Elmahkma { get; set; }
        [DisplayName(" الدائره")]
        public string Eldarea { get; set; }
        [DisplayName("تاريخ الاستلام")]
        public DateTime DateOfRecive { get; set; }
        [DisplayName("موضوع القضيه")]
        public string subject { get; set; }



    }
}