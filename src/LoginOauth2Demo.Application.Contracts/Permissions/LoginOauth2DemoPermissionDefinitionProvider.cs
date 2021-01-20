using LoginOauth2Demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LoginOauth2Demo.Permissions
{
    public class LoginOauth2DemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoginOauth2DemoPermissions.GroupName, L("Permission:LoginOauth2Demo"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoginOauth2DemoResource>(name);
        }
    }
}