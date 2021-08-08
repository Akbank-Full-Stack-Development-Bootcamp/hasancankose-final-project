using Bookstore.Business;
using Bookstore.Business.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(bookService.GetAllBooks());
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = bookService.GetBookById(id);
            if(book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddBook(AddNewBookRequest request)
        {
            if (ModelState.IsValid)
            {
                int bookId = bookService.AddBook(request);
                return Ok(bookId);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, EditBookRequest request)
        {
            var isExisting = bookService.GetBookById(id);
            if(isExisting == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                int newItemId = bookService.UpdateBook(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
