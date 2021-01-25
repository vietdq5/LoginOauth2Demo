using LoginOauth2Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    [ConnectionStringName(LoginOauth2DemoDbProperties.ConnectionStringName)]
    public interface ILoginOauth2DemoDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        public DbSet<Book> Books { get; set; }
    }
}