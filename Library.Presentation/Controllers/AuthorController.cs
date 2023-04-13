using Library.BAL.Contracts;
using Library.BAL.DataTranferObjects;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = authorService.GetAllAuthors();

            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult AuthorById(int id)
        {
            var author = authorService.GetAuthorById(id);

            return Ok(author);
        }

        [HttpPost]
        public IActionResult PostAuthor([FromBody] AuthorDTO author)
        {
            authorService.CreateAuthor(author);

            return Created("Post", author);
        }

        [HttpDelete]
        public IActionResult DeleteAuthor(int id)
        {
            authorService.DeleteAuhtor(id);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAuthor([FromQuery] int id ,[FromBody] AuthorDTO author)
        {
            authorService.UpdateAuthor(id, author);

            return Ok();
        }
    }
}
