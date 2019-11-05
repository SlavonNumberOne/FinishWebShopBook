using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.BusinessLogic.Servises;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess1.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _ibookservice;
        public BookController(ILogger<BookController> logger, IBookService ibookservice)
        {
            _logger = logger;
            _ibookservice = ibookservice;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
           return Ok(await _ibookservice.Get());
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _ibookservice.GetById(id));
           
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(Book book)
        {
            return Ok(await _ibookservice.Add(book));
     
        }
        [HttpPut("Update")]
        public IActionResult Update(Book book)
        {
          return Ok(_ibookservice.Update(book)); 
        } 

        [HttpDelete("Delete")]
        public IActionResult Delete(string id)
        {
          return Ok( _ibookservice.Delete(id));
        }
    } 
}

