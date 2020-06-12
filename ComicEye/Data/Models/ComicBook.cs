using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.Models
{
    public class ComicBook
    {

        /// <summary>
        /// Id
        /// </summary>
        public int id { get; set; } 

        /// <summary>
        /// Comic Book name
        /// </summary>
        public string name { get; set; } 

        /// <summary>
        /// Publisher
        /// </summary>
        public string publisher { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string shortDesc { get; set; }

        public string longDesc { get; set; }


        /// <summary>
        /// Year
        /// </summary>
        public int Year { get; set; } 

        public string img { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public ushort price { get; set; } 

        public bool isFavourite { get; set; }

        public bool available { get; set; }
        
        public virtual Category Category { get; set; }

    }
}
