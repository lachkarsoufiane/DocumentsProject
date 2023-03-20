using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using DataModel;
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
        public ActionResult<List<AuthorInfo>> GetAllAuthors()
        {
            var authors = authorService.GetAllAuthors();

            if (authors is null) return NotFound("No hay Authores");

            return Ok(authors);
        }

        
    }
}
