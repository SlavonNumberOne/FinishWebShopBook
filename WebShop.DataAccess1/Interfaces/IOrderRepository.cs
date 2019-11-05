using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess1.Entities;

namespace WebShop.DataAccess1.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> Get();
        Task<Order> GetById(string id);
        Task<Order> Add(Order order);
        Order Update(Order order);
        bool Delete(string id);
    }
}
