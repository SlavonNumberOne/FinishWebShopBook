using System.Linq;
using WebShop.DataAccess1.Context;
using WebShop.DataAccess1.Entities;


namespace WebShop.DataAccess1.Initialization
{
    public class DataBaseInitialization
    {
        private readonly ApplicationContext _context;
    
        public DataBaseInitialization(ApplicationContext context)
        {
            _context = context;
        }
        public void Initialize()
        {
            if (_context.Books.Any())
            {         
                return;   // DB has been seeded
            }
            var Books = new Book[]
            {
                new Book{ Name = "Carson",   Author = "Alexander", Price = 520, Year = 1998 },
                new Book{ Name = "Pupka",   Author = "Paska", Price = 1020, Year = 1696 },
                new Book{ Name = "Urka",   Author = "Triser", Price = 900, Year = 2090 }
            };

            foreach (Book b in Books)
            {
                _context.Books.Add(b);
            }
            _context.SaveChanges();
        }
        public void initAuthor()
        {
            if (_context.Authors.Any())
            {
                return;   // DB has been seeded
            }
            var Authors = new Author[]
            {
                new Author{ LastName = "Puuu",   FirstName = "Alex", Year = 1998 },
                new Author{ LastName = "Pupka",   FirstName = "Oleg", Year = 2500 },
            };

            foreach (Author a in Authors)
            {
                _context.Authors.Add(a);
            }
            _context.SaveChanges();
        }
    }
}
