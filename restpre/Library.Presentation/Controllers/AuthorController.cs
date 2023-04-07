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
        IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(authorService.GetAllAuthors());
        }

        [HttpGet("{id}")]
        public IActionResult AuthorById(int id)
        {
            return Ok(authorService.GetAuthorById(id));
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
