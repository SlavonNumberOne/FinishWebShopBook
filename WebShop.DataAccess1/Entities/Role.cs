using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
    public class Role : BaseEntity
    {
       public string Name { get; set; }
               
    }
}
