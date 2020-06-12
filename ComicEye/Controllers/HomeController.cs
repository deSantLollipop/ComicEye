using ComicEye.Data.interfaces;
using ComicEye.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Controllers
{
    public class HomeController : Controller
    {
        private IAllComics _comRep;

        public HomeController(IAllComics comRep)
        {
            _comRep = comRep;
        }


        public ViewResult Index()
        {
            var homeComics = new HomeViewModel
            {
                favComics = _comRep.getFavComics
            };
            return View(homeComics);
        }
    }
}
