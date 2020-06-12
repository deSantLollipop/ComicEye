using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.Models
{
    public class OrderDetail
    {

        public int id { get; set; }
        public int orderID { get; set; }
        public int ComicID { get; set; }
        public int price { get; set; }
        public virtual ComicBook comics { get; set; }
        public virtual Order order { get; set; }

      
    }
}
