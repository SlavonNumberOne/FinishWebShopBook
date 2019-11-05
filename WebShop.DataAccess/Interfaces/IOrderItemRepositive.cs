using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.DataAccess.Interfaces
{
   public interface IOrderItemRepositive
    {
        Task<IEnumerable<OrderItem>> GetOrd();
        Task<OrderItem> GetById(string id);
        OrderItem Update(OrderItem orderitem);
        bool Delete(string id);
    }
}

