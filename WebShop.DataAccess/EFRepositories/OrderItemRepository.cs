using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Entities;
using WebShop.DataAccess.Interfaces;

namespace WebShop.DataAccess.EFRepositories
{
  public  class OrderItemRepository : IOrderItemRepositive
    {
        private ApplicationContext _context;

        public OrderItemRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OrderItem>> GetOrd()
        {
            return await _context.OrderItems.ToAsyncEnumerable().ToList();
        }
        public async Task<OrderItem> GetById(string id)
        {
            return _context.OrderItems.Find(id);
        }
        public OrderItem Update(OrderItem orderitem)
        {
            _context.Update(orderitem).State = EntityState.Modified;
            return orderitem;
        }
        public bool Delete(string id)
        {
            try
            {
                OrderItem orderitem = _context.OrderItems.Find(id);
                var res = _context.OrderItems.Remove(orderitem);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
