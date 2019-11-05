using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.DataAccess.Interfaces
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
