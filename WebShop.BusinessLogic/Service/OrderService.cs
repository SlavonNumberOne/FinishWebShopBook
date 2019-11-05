using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.BusinessLogic.Servises
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _ordrepository;

        public OrderService(IOrderRepository ordrepository)
        {
            _ordrepository = ordrepository;
        }
        public async Task<IEnumerable<Order>> Get()
        {
            return await _ordrepository.Get();
        }
        public async Task<Order> GetById(string id)
        {
            return await _ordrepository.GetById(id);
        }
        public async Task<Order> Add(Order order)
        {
            return await _ordrepository.Add(order);
        }
        public Order Update(Order order)
        {
            return _ordrepository.Update(order);
        }
        public bool Delete(string id)
        {
            return _ordrepository.Delete(id);
        }
    }
}
