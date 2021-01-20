using LoginOauth2Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LoginOauth2Demo
{
    public abstract class LoginOauth2DemoController : AbpController
    {
        protected LoginOauth2DemoController()
        {
            LocalizationResource = typeof(LoginOauth2DemoResource);
        }
    }
}
