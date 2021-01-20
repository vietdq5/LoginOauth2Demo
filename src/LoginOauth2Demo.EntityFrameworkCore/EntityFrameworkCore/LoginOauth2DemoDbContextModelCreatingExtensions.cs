using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

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

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}