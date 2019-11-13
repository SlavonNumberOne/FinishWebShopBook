using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess1;

namespace WebShop.DataAccess1.Interfaces
{
  public interface IUserRepositive
    {
        Task<IEnumerable<User>> Get();
        User Update(User user);
        bool Delete(string name);
    }
}
