using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LoginOauth2Demo.MongoDB
{
    [ConnectionStringName(LoginOauth2DemoDbProperties.ConnectionStringName)]
    public interface ILoginOauth2DemoMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
