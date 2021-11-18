using Abp.Authorization;
using AcmeDemo.Authorization.Roles;
using AcmeDemo.Authorization.Users;

namespace AcmeDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
