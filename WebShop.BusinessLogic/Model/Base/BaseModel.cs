using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.BusinessLogic.Models
{
   public class BaseModel
    {
        public ICollection<string> Errors = new List<string>();
    }
}
