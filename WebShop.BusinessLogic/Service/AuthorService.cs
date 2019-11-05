using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.BusinessLogic.Interface;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.BusinessLogic.Servises
{
  public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorrepository;
        public AuthorService(IAuthorRepository authorrepository)
        {
            _authorrepository = authorrepository;
        }
        public async Task<IEnumerable<Author>> GetAuthor()
        {
            return await _authorrepository.GetAuthor();
        }
        public async Task<Author> GetById(string id)
        {
            return await _authorrepository.GetByIdAuthor(id);
        }
        public async Task<Author> AddAuthor(Author author)
        {
            return await _authorrepository.AddAuthor(author);
        }
        public Author UpdateAuthor(Author author)
        {
            return _authorrepository.UpdateAuthor(author);
        }
        public bool DeleteAuthor(string id)
        {
            return _authorrepository.DeleteAuthor(id);
        }
    }
}
