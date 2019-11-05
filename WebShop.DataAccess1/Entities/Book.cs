using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
  public  class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}
