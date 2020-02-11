using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using demo_microservices_netcore.Core;
using demo_microservices_netcore.Core.Models;
using demo_microservices_netcore.Diagnostics;

namespace demo_microservices_netcore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetAllBooks()
        {
            try
            {
                var core = new Book();
                var books = core.GetAllBooks();

                return Ok(books);
            }
            catch (System.Exception e)
            {
                var handler = new ErrorHandler(500 , e);
                _logger.LogError(handler.ConsoleResponse());
                return StatusCode(handler.StatusCode, handler.HttpResponse());
            }
        }
    }
}
