using ComicEye.Data.interfaces;
using ComicEye.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.mocks
{
    public class MockCategory : IComicCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                        new Category { categoryName = "Comics", desc = "Good old known comics"},
                        new Category { categoryName = "Manga/Manhwa", desc = "Japanese comics and South Korean comics"}
                       // , new Category { categoryName = "Manhwa", desc = "South Korean comics"}
                };
            }
        }
    }
}