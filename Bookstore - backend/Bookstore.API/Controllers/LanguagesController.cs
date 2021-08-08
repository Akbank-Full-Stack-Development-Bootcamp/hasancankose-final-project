using Bookstore.Business;
using Bookstore.Business.DataTransferObjects.LanguageDTO;
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
    public class LanguagesController : ControllerBase
    {
        private ILanguageService languageService;

        public LanguagesController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }

        [HttpGet]
        public IActionResult GetAllLanguages()
        {
            return Ok(languageService.GetAllLanguages());
        }

        [HttpPost]
        public IActionResult AddAuthor(AddNewLanguageRequest request)
        {
            if (ModelState.IsValid)
            {
                int languageId = languageService.AddLanguage(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
