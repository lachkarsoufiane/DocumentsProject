
using Model;

namespace Service
{
    public interface IDocumentService
    {
        Task<List<Document>> GetAllDocuments();
        Task<Document> GetDocumentById(Guid id);
    }
}
