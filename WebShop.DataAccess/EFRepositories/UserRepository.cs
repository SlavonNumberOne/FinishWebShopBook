using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Interfaces;
using WebShopDataAccesLear;

namespace WebShop.DataAccess.EFRepositories
{
   public class UserRepository : IUserRepositive
    {
        private ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
       public async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToAsyncEnumerable().ToList();
        }
        public User GetById(string id) 
        {
            return _context.Users.Find(id);
        }
        //public User GetUser(string name) 
        //{

        //}
        public async Task<User> Add(User user) 
        {
            var resus = await _context.Users.AddAsync(user);
            return resus.Entity;
        }
        public User Update(User user) 
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return user;
        }
        public bool Delete(string id) 
        {
            try
            {
                User user = _context.Users.Find(id);
                var resus = _context.Users.Remove(user);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool GetIsEmptyByName(string name) 
        {
            return _context.Users.Where(u => u.Name == name).FirstOrDefault() == null;
        }
    }
}
