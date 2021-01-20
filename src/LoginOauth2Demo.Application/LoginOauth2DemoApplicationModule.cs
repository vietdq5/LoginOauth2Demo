using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoDomainModule),
        typeof(LoginOauth2DemoApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LoginOauth2DemoApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LoginOauth2DemoApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LoginOauth2DemoApplicationModule>(validate: true);
            });
        }
    }
}
