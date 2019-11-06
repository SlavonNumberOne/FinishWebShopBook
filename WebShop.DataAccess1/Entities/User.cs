using Microsoft.AspNetCore.Identity;

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

    }
}
