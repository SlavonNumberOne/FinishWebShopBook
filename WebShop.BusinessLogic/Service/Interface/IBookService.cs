using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1.Entities;

namespace WebShop.BusinessLogic.Servises.Interface
{
   public interface IBookService
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(string id);
        Task<Book> Add(Book book);
        Book Update(Book book);
        bool Delete(string id);
        //List<string> GetNameBooks(List<int> booksId);

    }
}
