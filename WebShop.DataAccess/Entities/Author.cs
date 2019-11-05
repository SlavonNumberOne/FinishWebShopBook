using WebShop.DataAccess.Entities.Base;

namespace WebShop.DataAccess.Entities
{
  public  class Author : BaseEntity
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public int Year { get; set; }
    }
}
