using System;
using LoginOauth2Demo.Const;
using LoginOauth2Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    public static class LoginOauth2DemoDbContextModelCreatingExtensions
    {
        public static void ConfigureLoginOauth2Demo(
            this ModelBuilder builder,
            Action<LoginOauth2DemoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new LoginOauth2DemoModelBuilderConfigurationOptions(
                LoginOauth2DemoDbProperties.DbTablePrefix,
                LoginOauth2DemoDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<Book>(b =>
            {
                b.ToTable(ConfigDb.DbTablePrefix + "Books", ConfigDb.DbSchema);
                b.ConfigureByConvention();
            });
        }
    }
}