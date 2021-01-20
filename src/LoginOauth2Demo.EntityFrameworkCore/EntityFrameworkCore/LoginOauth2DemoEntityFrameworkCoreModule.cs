using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoginOauth2Demo.EntityFrameworkCore
{
    [DependsOn(
        typeof(LoginOauth2DemoDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LoginOauth2DemoEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LoginOauth2DemoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}