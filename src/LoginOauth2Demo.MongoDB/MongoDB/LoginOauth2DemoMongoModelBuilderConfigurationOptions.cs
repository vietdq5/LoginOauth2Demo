using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace LoginOauth2Demo.MongoDB
{
    public class LoginOauth2DemoMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public LoginOauth2DemoMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}