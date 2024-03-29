﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using WebShop.DataAccess1.Context;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.DataAccess1.EFRepositories
{
   public class OrderRepository : IOrderRepository
    {
        private ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Order>> Get()
        {
            return await _context.Orders.ToAsyncEnumerable().ToList();

        }
        public async Task<Order> GetById(string id)
        {
            return _context.Orders.Find(id);
        }
        public async Task<Order> Add(Order order)
        {
            var resord = await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return resord.Entity;
        }
        public Order Update(Order order)
        {
            _context.Update(order).State = EntityState.Modified;
            return order;
        }
        public bool Delete(string id)
        {
            try
            {
                Order order = _context.Orders.Find(id);
                var res = _context.Orders.Remove(order);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
