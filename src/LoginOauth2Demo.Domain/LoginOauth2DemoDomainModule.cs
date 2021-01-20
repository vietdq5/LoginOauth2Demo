using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace LoginOauth2Demo
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LoginOauth2DemoDomainSharedModule)
    )]
    public class LoginOauth2DemoDomainModule : AbpModule
    {

    }
}
