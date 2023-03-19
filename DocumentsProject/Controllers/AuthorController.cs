using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace DocumentsProject.Controllers
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
        public async Task<ActionResult<List<Author>>> GetAllAuthors()
        {
            var authors = await authorService.GetAllAuthors();

            if (authors is null) return NotFound("No hay Authores");

            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthorById(Guid id)
        {
            var author = await authorService.GetAuthorById(id);
            //Si el author no existe mostramos el mensaje 
            if (author is null) return NotFound($"El author con el id {id} no existe");

            return Ok(author);
        }


        [HttpPost]
        public async Task<ActionResult<List<Author>>> AddAuthor(Author author)
        {
            var result = await authorService.AddAuthor(author);

            return Ok(result);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<List<Author>>> UpdateAuthor(Guid id, Author request)
        {
            var result = await authorService.UpdateAuthor(id, request);
            return Ok(result);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<List<Author>>> DeleteAuthor(Guid id)
        {
            var result = await authorService.DeleteAuthor(id);
            if (result is null) return NotFound($"El author con el id {id} no existe");

            return Ok(result);
        }


        
        
    }
}
