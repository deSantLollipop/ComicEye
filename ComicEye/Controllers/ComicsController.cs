using ComicEye.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using ComicEye.ViewModels;
using System.Collections;
using ComicEye.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ComicEye.Controllers
{
    public class ComicsController : Controller
    {
        private readonly IAllComics _allComics;
        private readonly IComicCategory _comicCategory;

        public ComicsController(IAllComics iAllComics, IComicCategory iComicCat) 
        {
            _allComics = iAllComics;
            _comicCategory = iComicCat;     
        }

        [Route("Comics/List")]
        [Route("Comics/List/{category}")]
        public ViewResult List(string category) 
        {
            string _category = category;
            IEnumerable<ComicBook> comics = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                comics = _allComics.Comics.OrderBy(i => i.id);
            }
            else 
            {
                if (string.Equals("manga", category, StringComparison.OrdinalIgnoreCase))
                {
                    comics = _allComics.Comics.Where(i => i.Category.categoryName == "Manga/Manhwa").OrderBy(i => i.id);
                }
                else if (string.Equals("comics", category, StringComparison.OrdinalIgnoreCase))
                {
                    comics = _allComics.Comics.Where(i => i.Category.categoryName.Equals("Comics")).OrderBy(i => i.id);
                }
                
            }
            currCategory = category;
            var comObj = new ComicsListViewModel
            {
                AllComics = comics,
                comCategory = currCategory
            };

            ViewBag.Title = "Comic Page";
            
            return View(comObj);
        }
    
    }
}
