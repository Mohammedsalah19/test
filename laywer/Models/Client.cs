using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace laywer.Models
{
    public class Client
    {
        [Key] 
        public int ID { get; set; } 
        [Required]
        [DisplayName("أسم الموكل")] 
        public string Name { get; set; } 
        [DisplayName(" الجنسيه")] 
        public string Nationality { get; set; } 
        [Required] 

        [DisplayName(" العنوان")] 

        public string Address { get; set; } 
        [DisplayName(" الديانه")] 
 
        public string eldiana { get; set; } 
        [Required] 
        [DisplayName(" رقم التليفون")] 
 
 
        public string Mobile { get; set; } 
        [DisplayName(" البريد الاكترونى")] 
        public string Email { get; set; } 

        [DisplayName("ملاحظات ")] 
         public string Notes { get; set; }

    }
}