using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    public class LoginOauth2DemoHttpApiHostMigrationsDbContext : AbpDbContext<LoginOauth2DemoHttpApiHostMigrationsDbContext>
    {
        public LoginOauth2DemoHttpApiHostMigrationsDbContext(DbContextOptions<LoginOauth2DemoHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureLoginOauth2Demo();
        }
    }
}
