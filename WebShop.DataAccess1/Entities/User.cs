using Microsoft.AspNetCore.Identity;

namespace WebShop.DataAccess1
{
   public class User: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; internal set; }
    }
}
