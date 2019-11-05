using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.DataAccess.Interfaces
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
