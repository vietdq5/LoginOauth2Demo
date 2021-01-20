using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using LoginOauth2Demo.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LoginOauth2DemoDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LoginOauth2DemoDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<LoginOauth2DemoResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/LoginOauth2Demo");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("LoginOauth2Demo", typeof(LoginOauth2DemoResource));
            });
        }
    }
}
