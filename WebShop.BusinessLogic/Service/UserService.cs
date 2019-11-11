using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1;
using WebShop.DataAccess1.Interfaces;

namespace WebShop.BusinessLogic.Service
{
    public class UserService
    {
        private readonly IUserRepositive _repository;
        public UserService(IUserRepositive repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.Get();
        }
        public User Update(User user)
        {
            return _repository.Update(user);
        }
        //public Task<User> Delete(string id)
        //{
        //    return  _repository.Delete(id);
        //}
    }
}
