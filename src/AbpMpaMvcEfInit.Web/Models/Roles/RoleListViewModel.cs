using System.Collections.Generic;
using AbpMpaMvcEfInit.Roles.Dto;

namespace AbpMpaMvcEfInit.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}