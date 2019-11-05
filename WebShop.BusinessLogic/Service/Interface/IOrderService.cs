using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess1.Entities;

namespace WebShop.BusinessLogic.Servises.Interface
{
 public interface IOrderService
    {
        Task<IEnumerable<Order>> Get();
        Task<Order> GetById(string id);
        Task<Order> Add(Order order);
        Order Update(Order order);
        bool Delete(string id);
    }
}
