using WebShopDataAccesLear;
using WebShop.DataAccess.Entities.Base;

namespace WebShop.DataAccess.Entities
{
   public class UserRole: BaseEntity
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
