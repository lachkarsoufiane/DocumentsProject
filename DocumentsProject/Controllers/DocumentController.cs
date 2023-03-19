using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace DocumentsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {

        private readonly IDocumentService documentService;
        public DocumentController(IDocumentService documentService) 
        {
            this.documentService = documentService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Document>>> GetAllDocuments()
        {
            var documents = await documentService.GetAllDocuments();
            if (documents is null)
                return NotFound("No hay documentos");

            return Ok(documents);
        }



    }
}
