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
        AuthorInfo GetAuthorById(Guid id);
        List<Author> AddAuthor(AuthorInfo author);

        List<Author> UpdateAuthor(Guid id, Author request);
        List<Author> DeleteAuthor(Guid id);

    }
}
