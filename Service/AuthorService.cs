using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using DataModel;

namespace Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IPracticeContextFactory contextFactory;

        public AuthorService(IPracticeContextFactory context)
        {
            this.contextFactory = context;
        }


        public List<AuthorInfo> GetAllAuthors()
        {
            using (var context = contextFactory.CreateContext())
            {

                List<AuthorInfo> result = new List<AuthorInfo>();

                result.AddRange(context.Authors.Select(author => author.Adapt<AuthorInfo>()).ToList());

                return result;
            }
        }

        public AuthorInfo GetAuthorById(Guid id)
        {
            throw new NotImplementedException();
        }


        public List<Author> AddAuthor(AuthorInfo author)
        {
            throw new NotImplementedException();
        }

        public List<Author> DeleteAuthor(Guid id)
        {
            throw new NotImplementedException();
        }


        public List<Author> UpdateAuthor(Guid id, Author request)
        {
            throw new NotImplementedException();
        }
    }
}
