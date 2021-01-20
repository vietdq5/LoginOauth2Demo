using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    public class LoginOauth2DemoModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public LoginOauth2DemoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}