using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    public class LoginOauth2DemoHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LoginOauth2DemoHttpApiHostMigrationsDbContext>
    {
        public LoginOauth2DemoHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LoginOauth2DemoHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("LoginOauth2Demo"));

            return new LoginOauth2DemoHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
