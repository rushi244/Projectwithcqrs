﻿using Microsoft.AspNetCore.Mvc;
using DomainLibrary.Models;

namespace Projectwithcqrs.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PostController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post { Id = id, Text = "Hello Universe" };
            return Ok(post);
        }
    }
}
