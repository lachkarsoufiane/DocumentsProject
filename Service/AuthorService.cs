using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AuthorService : IAuthorService
    {
        private readonly PracticeContext context;

        public AuthorService(PracticeContext context)
        {
            this.context = context;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            var authors = await context.Authors.ToListAsync();
            return authors;
        }

        public async Task<Author>? GetAuthorById(Guid id)
        {
            var author = await context.Authors.FindAsync(id);

            return author;
        }

        public async Task<List<Author>> AddAuthor(Author author)
        {
            context.Authors.Add(author);

            await context.SaveChangesAsync();

            return await context.Authors.ToListAsync() ;
        }


        
    }
}
