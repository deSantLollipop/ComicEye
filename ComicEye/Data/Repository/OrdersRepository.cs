﻿using ComicEye.Data.interfaces;
using ComicEye.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ComicID = el.comicBook.id,
                    orderID = order.id,
                    price = el.comicBook.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
