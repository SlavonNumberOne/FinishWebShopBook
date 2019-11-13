using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1.Context;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.DataAccess1.EFRepositories
{
    public class UserRepository1 : IUserRepositive
    {
        private ApplicationContext _context;
        public UserRepository1(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToAsyncEnumerable().ToList();
        }
        public User Update(User user)
        {
            _context.Set<User>().Update(user);
            _context.SaveChanges();
            return user;
        }
        public bool Delete(string name)
        {
            try
            {
                User user = _context.Users.Find(name);
                var res = _context.Users.Remove(user);
                _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        
    }
}

