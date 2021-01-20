using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LoginOauth2Demo.MongoDB
{
    [ConnectionStringName(LoginOauth2DemoDbProperties.ConnectionStringName)]
    public class LoginOauth2DemoMongoDbContext : AbpMongoDbContext, ILoginOauth2DemoMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureLoginOauth2Demo();
        }
    }
}