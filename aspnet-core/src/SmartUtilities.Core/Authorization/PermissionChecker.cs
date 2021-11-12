using Abp.Authorization;
using SmartUtilities.Authorization.Roles;
using SmartUtilities.Authorization.Users;

namespace SmartUtilities.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
