using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1;

namespace WebShop.BusinessLogic.Service.Interface
{
   public interface IUserService
   {
        Task<IEnumerable<User>> Get();
        User Update(User user);
      //  Task<User> Delete(string id);
   }

}
