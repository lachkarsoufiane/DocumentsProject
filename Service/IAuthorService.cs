using Model;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAuthorService
    {
        List<AuthorInfo> GetAllAuthors();
        Task<Author> GetAuthorById(Guid id);
        Task<List<Author>> AddAuthor(Author author);

        Task<List<Author>> UpdateAuthor(Guid id, Author request);
        Task<List<Author>> DeleteAuthor(Guid id);

    }
}
