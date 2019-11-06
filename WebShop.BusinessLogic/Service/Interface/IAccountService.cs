using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.BusinessLogic.Servises.Interface
{
    public interface IAccountService
    {
        void SignUp(string username, string password);

    }
}
