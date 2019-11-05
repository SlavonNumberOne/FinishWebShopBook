using WebShop.DataAccess.Entities.Base;

namespace WebShop.DataAccess.Entities
{
  public  class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}
