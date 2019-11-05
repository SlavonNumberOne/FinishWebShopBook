using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
  public  class Author : BaseEntity
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public int Year { get; set; }
    }
}
