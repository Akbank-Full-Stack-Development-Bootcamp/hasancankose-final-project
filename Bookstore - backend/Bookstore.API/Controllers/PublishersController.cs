using Bookstore.Business;
using Bookstore.Business.DataTransferObjects.PublisherDTO;
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
    public class PublishersController : ControllerBase
    {
        private IPublisherService publicherService;

        public PublishersController(IPublisherService publicherService)
        {
            this.publicherService = publicherService;
        }

        [HttpGet]
        public IActionResult GetAllPublishers()
        {
            return Ok(publicherService.GetAllPublishers());
        }

        [HttpPost]
        public IActionResult AddPublisher(AddNewPublisherRequest request)
        {
            if (ModelState.IsValid)
            {
                int publsiherId = publicherService.AddPublisher(request);
                return Ok();
            }
            return BadRequest();
        }
    }
}
