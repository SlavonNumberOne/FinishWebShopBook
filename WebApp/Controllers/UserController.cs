using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filters;
using WebShop.BusinessLogic.Service.Interface;
using WebShop.DataAccess1;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _iuserservice;
        public UserController(IUserService iuserservice, UserManager<User> userManager)
        {
            _userManager = userManager;
            _iuserservice = iuserservice;
        }

        [ExceptionFilter]
        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            return Ok(_iuserservice.Update(user));
        }

        [ExceptionFilter]
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                
            }
            return Ok();
        }

    }
}
