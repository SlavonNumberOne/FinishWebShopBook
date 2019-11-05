using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Entities;
using WebShop.DataAccess.Interfaces;

namespace WebShop.DataAccess.EFRepositories
{
  public  class AuthorRepository : IAuthorRepository
    {
        private ApplicationContext _context;
        public AuthorRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Author>> GetAuthor()
        {
            return await _context.Authors.ToAsyncEnumerable().ToList();

        }
        public async  Task<Author> GetByIdAuthor(string id)
        {
            return _context.Authors.Find(id);
        }
        public async Task<Author> AddAuthor(Author author)
        {
            var res = await _context.Authors.AddAsync(author);
            return res.Entity;
        }
        public  Author UpdateAuthor(Author author)
        {
            _context.Authors.Update(author).State = EntityState.Modified;
            return author;
        }
        public bool DeleteAuthor(string id)
        {
            try
            {
                Author author = _context.Authors.Find(id);
                var resaut = _context.Authors.Remove(author);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
