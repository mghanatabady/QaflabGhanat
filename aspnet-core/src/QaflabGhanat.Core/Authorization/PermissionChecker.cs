using Abp.Authorization;
using QaflabGhanat.Authorization.Roles;
using QaflabGhanat.Authorization.Users;

namespace QaflabGhanat.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
