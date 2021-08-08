using Bookstore.Business;
using Bookstore.Business.DataTransferObjects.AuthorDTO;
using Bookstore.Models;
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
    public class AuthorsController : ControllerBase
    {
        private IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            return Ok(authorService.GetAllAuthors());
        }

        [HttpPost]
        public IActionResult AddAuthor(AddNewAuthorRequest request)
        {
            if(ModelState.IsValid)
            {
                int authorId = authorService.AddAuthor(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
