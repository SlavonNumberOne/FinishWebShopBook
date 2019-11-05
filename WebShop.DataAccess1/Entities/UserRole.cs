using WebShop.DataAccess1;
using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
   public class UserRole: BaseEntity
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
