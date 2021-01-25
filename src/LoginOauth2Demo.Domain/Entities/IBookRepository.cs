using System;
using Volo.Abp.Domain.Repositories;

namespace LoginOauth2Demo.Entities
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}