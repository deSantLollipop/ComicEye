using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public virtual ComicBook comicBook { get; set; }

        public int price { get; set; }

        public string ShopCartId { get; set; }
    
    }
}
