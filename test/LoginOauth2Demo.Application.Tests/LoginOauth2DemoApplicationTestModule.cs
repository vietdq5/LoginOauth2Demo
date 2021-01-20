using Volo.Abp.Modularity;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoApplicationModule),
        typeof(LoginOauth2DemoDomainTestModule)
        )]
    public class LoginOauth2DemoApplicationTestModule : AbpModule
    {

    }
}
