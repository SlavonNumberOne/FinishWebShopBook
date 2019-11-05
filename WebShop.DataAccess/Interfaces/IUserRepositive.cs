using System.Collections.Generic;
using System.Threading.Tasks;
using WebShopDataAccesLear;

namespace WebShop.DataAccess.Interfaces
{
  public interface IUserRepositive
    {
        Task<IEnumerable<User>> Get();
        User GetById(string id);
       // User GetUser(string name);
        Task<User> Add(User user);
        User Update(User user);
        bool Delete(string id);
        bool GetIsEmptyByName(string name);
    }
}
