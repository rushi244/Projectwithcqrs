using Microsoft.AspNetCore.Mvc;
using DomainLibrary.Models;

namespace Projectwithcqrs.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PostController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post { Id = id, Text = "Hello World" };
            return Ok(post);
        }
    }
}
