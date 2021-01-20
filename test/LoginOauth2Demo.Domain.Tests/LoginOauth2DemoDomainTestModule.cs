using LoginOauth2Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoginOauth2Demo
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(LoginOauth2DemoEntityFrameworkCoreTestModule)
        )]
    public class LoginOauth2DemoDomainTestModule : AbpModule
    {
        
    }
}
