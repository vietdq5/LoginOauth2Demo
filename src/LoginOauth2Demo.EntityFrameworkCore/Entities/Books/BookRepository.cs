using LoginOauth2Demo.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LoginOauth2Demo.Entities
{
    public class BookRepository : EfCoreRepository<LoginOauth2DemoDbContext, Book, Guid>, IBookRepository
    {
        public BookRepository(IDbContextProvider<LoginOauth2DemoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}