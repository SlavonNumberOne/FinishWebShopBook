using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1.Entities;

namespace WebShop.DataAccess1.Interfaces
{
  public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthor();
        Task<Author> GetByIdAuthor(string id);
        Task<Author> AddAuthor(Author author);
        Author UpdateAuthor(Author author);
        bool DeleteAuthor(string id);
    }
}
