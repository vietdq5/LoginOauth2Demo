using LoginOauth2Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    [ConnectionStringName(LoginOauth2DemoDbProperties.ConnectionStringName)]
    public class LoginOauth2DemoDbContext : AbpDbContext<LoginOauth2DemoDbContext>, ILoginOauth2DemoDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Book> Books { get; set; }

        public LoginOauth2DemoDbContext(DbContextOptions<LoginOauth2DemoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureLoginOauth2Demo();
        }
    }
}