using Localization.Resources.AbpUi;
using LoginOauth2Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LoginOauth2DemoHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LoginOauth2DemoHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<LoginOauth2DemoResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
