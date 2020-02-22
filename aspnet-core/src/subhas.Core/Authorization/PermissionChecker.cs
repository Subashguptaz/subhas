using Abp.Authorization;
using subhas.Authorization.Roles;
using subhas.Authorization.Users;

namespace subhas.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
