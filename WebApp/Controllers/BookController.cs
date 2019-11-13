using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Filters;
using WebShop.BusinessLogic.Servises;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess1.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{ 
    [Authorize]
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

        [HttpGet("getbooks")]
    
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                _logger.LogInformation("Fetching all the Students from the storage");
                return Ok(await _ibookservice.GetBooks());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(500, "Internal server error");
            }
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
        [ExceptionFilter]
        [HttpPut("Update")]
        public IActionResult Update(Book book)
        {
          return Ok(_ibookservice.Update(book)); 
        }

        [ExceptionFilter]
        [HttpDelete("Delete")]
        public IActionResult Delete(string id)
        {
          return Ok( _ibookservice.Delete(id));
        }
    } 
}

