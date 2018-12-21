using Abp.Authorization;
using Graby.Life.Authorization.Roles;
using Graby.Life.Authorization.Users;

namespace Graby.Life.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
