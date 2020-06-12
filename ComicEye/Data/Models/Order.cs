using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Input Name")]
        [StringLength(5)]
        [Required(ErrorMessage ="Leangth not lower then 5")]
        public string name { get; set; }

        [Display(Name = "Input Surname")]
        [StringLength(5)]
        [Required(ErrorMessage = "Leangth not lower then 5")]
        public string surname { get; set; }

        [Display(Name = "Input Adress")]
        [StringLength(15)]
        [Required(ErrorMessage = "Leangth not lower then 15")]
        public string adress { get; set; }

        [Display(Name = "Input Email")]
        [StringLength(10)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Leangth not lower then 10")]
        public string email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public virtual List<OrderDetail> orderDetails { get; set; }

    }
}
