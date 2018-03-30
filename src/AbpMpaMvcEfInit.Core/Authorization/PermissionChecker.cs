using Abp.Authorization;
using AbpMpaMvcEfInit.Authorization.Roles;
using AbpMpaMvcEfInit.Authorization.Users;

namespace AbpMpaMvcEfInit.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
