using LoginOauth2Demo.Localization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace LoginOauth2Demo
{
    [RemoteService(Name = "LoginOauth2DemoBook")]
    [Authorize]
    [IgnoreAntiforgeryToken]
    public abstract class LoginOauth2DemoController : AbpController
    {
        protected LoginOauth2DemoController()
        {
            LocalizationResource = typeof(LoginOauth2DemoResource);
        }
    }
}
