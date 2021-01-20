using Volo.Abp.Reflection;

namespace LoginOauth2Demo.Permissions
{
    public class LoginOauth2DemoPermissions
    {
        public const string GroupName = "LoginOauth2Demo";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(LoginOauth2DemoPermissions));
        }
    }
}