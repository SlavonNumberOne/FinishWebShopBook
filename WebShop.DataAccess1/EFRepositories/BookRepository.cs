﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.DataAccess1.Context;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.DataAccess1.EFRepositories
{
    public class BookRepository : IBookRepository
    {
        private ApplicationContext _context;
        public BookRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToAsyncEnumerable().ToList();

        }
        public async Task<Book> GetById(string id)
        {
            return _context.Books.Find(id);
        }
        public async Task<Book> Add(Book book)
        {
          var res = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
          return res.Entity;
        }
        public Book Update(Book book)
        {
            _context.Update(book).State = EntityState.Modified;
            return book;

        }
        public bool Delete(string id)
        {
            try
            {
                Book book = _context.Books.Find(id);
                var res = _context.Books.Remove(book);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
