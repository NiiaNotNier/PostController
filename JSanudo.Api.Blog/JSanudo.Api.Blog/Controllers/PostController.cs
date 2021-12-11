using JSanudo.Api.Blog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSanudo.Api.Blog.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        // Obtener todos

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAllPosts()
        {
            if (DbContext.ListaPosts.Any())
                return Ok(DbContext.ListaPosts);
            else
                return NoContent();
        }

        // Obtener por Id

        [HttpGet("{id}")]
        public ActionResult<Post> GetPostById(int id)
        {
            if (DbContext.ListaPosts.Any(p => p.Id == id))
                return Ok(DbContext.ListaPosts.FirstOrDefault(p => p.Id == id));
            else
                return NoContent();
        }

        // Obtener por title

        [HttpGet("{title}")]
        public ActionResult<Post> GetPostByTitle(string title) //falta usando el símbolo de % como carácter comodín
        {
            if (DbContext.ListaPosts.Any(p => p.Title == title))
                return Ok(DbContext.ListaPosts.FirstOrDefault(p => p.Title == title));
            else
                return NoContent();
        }

        // Obtener por body

        [HttpGet("{body}")]
        public ActionResult<Post> GetPostByBody(string body) //falta usando el símbolo de % como carácter comodín
        {
            if (DbContext.ListaPosts.Any(p => p.Body  == body))
                return Ok(DbContext.ListaPosts.FirstOrDefault(p => p.Body  == body));
            else
                return NoContent();
        }

        // POST ADD

        [HttpPost]
        public IActionResult Post([FromBody] Post value)
        {
            if (!DbContext.ListaPosts.Any(p => p.Id == value.Id))
            {
                DbContext.ListaPosts.Add(value);
                return Ok();
            }
            else
            {
                return BadRequest($"Ya existe una direccion con esta ID: {value.Id}");
            }
        }

        // MODIFY
        [HttpPut("{id}")]
        public ActionResult Edit(int id, [FromBody] Post value)
        {
            var DireccionesToUpdate = DbContext.ListaPosts.Single(p => p.Id == id);
            DbContext.ListaPosts.Remove(DireccionesToUpdate);
            DbContext.ListaPosts.Add(value);
            return View();
        }

        // DELETE

        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] Post value)
        {
            var PostToDelete = DbContext.ListaPosts.Single(p => p.Id == id);
            DbContext.ListaPosts.Remove(PostToDelete);
        }
    }
}