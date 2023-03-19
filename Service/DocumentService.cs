using Data;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service
{
    public class DocumentService : IDocumentService
    {

        private readonly PracticeContext context;

        public DocumentService(PracticeContext context) 
        {
            this.context = context;    
        }

        public async Task<List<Document>?> GetAllDocuments()
        {
           var documents = await this.context.Documents.ToListAsync();
            if (documents is null)
                return null;

            return documents;
        }

        public Task<Document> GetDocumentById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}