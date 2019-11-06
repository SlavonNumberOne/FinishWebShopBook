using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.BusinessLogic.Interface;
using WebShop.DataAccess1.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _iauthorservice;
        public AuthorController(ILogger<AuthorController> logger, IAuthorService iauthorService)
        {
            _logger = logger;
            _iauthorservice = iauthorService;
        }

        // GET: /<controller>/
        //private readonly IAuthorService _iauthorservice;
        //public AuthorController(IAuthorService iauthorservice)
        //{
        //    _iauthorservice = iauthorservice;
        //}
        [HttpGet("getauthor")]
        public async Task<IActionResult> GetAuthor()
        {
            return Ok(await _iauthorservice.GetAuthor());
        }
        [HttpGet("getidauthor")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _iauthorservice.GetById(id));

        }
        [HttpPost("addauthor")]
        public async Task<IActionResult> AddAuthor(Author author)
        {
            //return Ok(await _iauthorservice.AddAuthor(author));
            return Ok(await _iauthorservice.AddAuthor(author));
        }
        [HttpPut("updateauthor")]
        public IActionResult UpdateAuthor(Author author)
        {
            return Ok(_iauthorservice.UpdateAuthor(author));
        }

        [HttpDelete("deleteauthor")]
        public IActionResult DeleteAuthor(string id)
        {
            return Ok(_iauthorservice.DeleteAuthor(id));
        }
    }
}