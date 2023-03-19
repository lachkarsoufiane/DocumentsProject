using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(Guid id);
        Task<List<Author>> AddAuthor(Author author);
    }
}
