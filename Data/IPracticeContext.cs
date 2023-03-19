using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public interface IPracticeContext : IDisposable
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<DocumentsAuthor> DocumentsAuthors { get; set; }
    }
}