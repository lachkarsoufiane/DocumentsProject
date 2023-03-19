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

        public Task<List<Author>> AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> DeleteAuthor(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AuthorInfo>> GetAllAuthors()
        {
            using ( var context = contextFactory.CreateContext()) { 

                List<AuthorInfo> result = new List<AuthorInfo>();

                //var authors = await context.Authors.ToListAsync();

                result.AddRange(context.Authors.Select(author => author.Adapt<AuthorInfo>()).ToListAsync());

                return result;
            }
        }

        public Task<Author> GetAuthorById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> UpdateAuthor(Guid id, Author request)
        {
            throw new NotImplementedException();
        }
    }
}
