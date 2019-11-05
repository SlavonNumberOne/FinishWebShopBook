using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1.Entities;

namespace WebShop.DataAccess1.Interfaces
{
  public  interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(string id);
        Task<Book> Add(Book book);
        Book Update(Book book);
        bool Delete(string id);
    }
}
