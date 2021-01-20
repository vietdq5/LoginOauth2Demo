using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace LoginOauth2Demo.MongoDB
{
    [DependsOn(
        typeof(LoginOauth2DemoDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class LoginOauth2DemoMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<LoginOauth2DemoMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
