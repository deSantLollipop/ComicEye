using ComicEye.Data.interfaces;
using ComicEye.Data.Models;
using ComicEye.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllComics _comRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllComics comRep, ShopCart shopCart)
        {
            _comRep = comRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);

        }
    
        public RedirectToActionResult addToCart(int id)
        {
            var item = _comRep.Comics.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }


    }
}
