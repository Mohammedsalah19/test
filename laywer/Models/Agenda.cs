using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class Agenda
    {
        public int id { get; set; }
        public int numberCase { get; set; }
        public int FileNumber{ get; set; }
        public DateTime DateOfGalas { get; set; }
        public string ClientName { get; set; }
        public string TypeOfClinet { get; set; }
        public string GuilityName { get; set; }
        public string TypeOfGuility { get; set; }


    }
}