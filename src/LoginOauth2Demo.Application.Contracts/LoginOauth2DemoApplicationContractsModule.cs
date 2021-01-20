using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(LoginOauth2DemoDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LoginOauth2DemoApplicationContractsModule : AbpModule
    {

    }
}
