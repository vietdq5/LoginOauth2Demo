using LoginOauth2Demo.Localization;
using Volo.Abp.Application.Services;

namespace LoginOauth2Demo
{
    public abstract class LoginOauth2DemoAppService : ApplicationService
    {
        protected LoginOauth2DemoAppService()
        {
            LocalizationResource = typeof(LoginOauth2DemoResource);
            ObjectMapperContext = typeof(LoginOauth2DemoApplicationModule);
        }
    }
}
