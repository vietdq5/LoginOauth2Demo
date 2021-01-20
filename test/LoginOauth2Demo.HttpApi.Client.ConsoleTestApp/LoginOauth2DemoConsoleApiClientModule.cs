using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LoginOauth2DemoConsoleApiClientModule : AbpModule
    {
        
    }
}
