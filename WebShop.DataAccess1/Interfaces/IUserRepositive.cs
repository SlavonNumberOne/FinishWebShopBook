using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess1;

namespace WebShop.DataAccess1.Interfaces
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
