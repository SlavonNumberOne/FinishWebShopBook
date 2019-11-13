using Microsoft.AspNetCore.Identity;
using WebShop.DataAccess1.Entities;

namespace WebShop.DataAccess1
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
