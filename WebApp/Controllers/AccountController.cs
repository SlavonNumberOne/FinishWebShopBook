using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.BusinessLogic.ViewModels;
using WebShop.DataAccess1.Entities;
using WebShop.DataAccess1;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using WebShop.DataAccess1.Context;
using WebApp.Filters;
using System.Net.Mail;
using WebShop.BusinessLogic.Service;
using System.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebShop.BusinessLogic.Helpers;
using WebShop.DataAccess1.Interfaces;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AccountController> _logger;
       // private ApplicationContext _context;
  
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _logger = logger;
            //_context = context;
            //_userRepositive = userRepositive;
        }

        [ExceptionFilter]
        [HttpGet]
        public string GetLogRegis()
        {
            return "getregist";
        }

        [ExceptionFilter]
        [HttpPost("login")]
        public async Task<object> Login([FromBody] LoginViewModel login)
        {
            _logger.LogInformation("Log message in the Login() method");
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
                try
                {
                    if (result.Succeeded)
                    {
                        var appUser = _userManager.Users.SingleOrDefault(u => u.Email == login.Email);
                        return await GenerateJwtToken(login.Email, appUser);
                    }
                }
                catch (Exception ex)
                {
                    ;
                }
             throw new ApplicationException("INVALID_LOGIN_ATTEMPT");
        }

        [ExceptionFilter]
        [HttpPost("register")]
        public async Task<object> Register([FromBody] User regist)
        {
            _logger.LogInformation("Log message in the Register() method");
            var user = new User { UserName = regist.Email, Name = regist.Name, Email = regist.Email, PasswordHash = regist.PasswordHash };
            var result = await _userManager.CreateAsync(user, regist.PasswordHash);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return GenerateJwtToken(regist.Email, user);
            }
            throw new ApplicationException("UNKNOWN_ERROR");
        }

        [ExceptionFilter]
        private async Task<object> GenerateJwtToken(string email, User user)
        {
            var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.Name),
                   
                };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
      
    }
}

