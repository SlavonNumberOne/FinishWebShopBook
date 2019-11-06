using Microsoft.AspNetCore.Identity;
using System;

namespace WebShop.DataAccess1
{
   public class User: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Build { get; set; } //стать человека
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
   }
}
