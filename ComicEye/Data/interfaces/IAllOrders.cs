using ComicEye.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
