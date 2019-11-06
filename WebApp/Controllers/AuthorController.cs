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
        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        private readonly IAuthorService _iauthorservice;
        public AuthorController(IAuthorService iauthorservice)
        {
            _iauthorservice = iauthorservice;
        }
        [HttpGet("GetAuthor")]
        public async Task<IActionResult> GetAuthor()
        {
            return Ok(await _iauthorservice.GetAuthor());
        }
        [HttpGet("GetIdAuthor")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _iauthorservice.GetById(id));

        }
        [HttpPost("AddAuthor")]
        public async Task<IActionResult> AddAuthor(Author author)
        {
            return Ok(await _iauthorservice.AddAuthor(author));

        }
        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(Author author)
        {
            return Ok(_iauthorservice.UpdateAuthor(author));
        }

        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor(string id)
        {
            return Ok(_iauthorservice.DeleteAuthor(id));
        }
    }
}