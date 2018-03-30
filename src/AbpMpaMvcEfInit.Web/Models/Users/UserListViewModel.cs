using System.Collections.Generic;
using AbpMpaMvcEfInit.Roles.Dto;
using AbpMpaMvcEfInit.Users.Dto;

namespace AbpMpaMvcEfInit.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}