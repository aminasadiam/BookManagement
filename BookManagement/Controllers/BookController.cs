using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var book = bookRepository.GetAll();
            return Ok(book);
        }

    }
}
