using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class LoginOauth2DemoHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "LoginOauth2Demo";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(LoginOauth2DemoApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
