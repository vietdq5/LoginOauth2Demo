using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace LoginOauth2Demo.MongoDB
{
    public static class LoginOauth2DemoMongoDbContextExtensions
    {
        public static void ConfigureLoginOauth2Demo(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new LoginOauth2DemoMongoModelBuilderConfigurationOptions(
                LoginOauth2DemoDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}