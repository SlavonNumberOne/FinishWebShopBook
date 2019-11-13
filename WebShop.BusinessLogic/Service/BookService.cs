using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.BusinessLogic.Interface;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.BusinessLogic.Servises
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }
       public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _repository.GetBooks();
            
        }
        public async Task<Book> GetById(string id)
        {
            return await _repository.GetById(id);
        }
        public async Task<Book> Add(Book book)
        {
            return await _repository.Add(book);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
        public bool Delete(string id)
        {
            return _repository.Delete(id);
        }

    }
}
