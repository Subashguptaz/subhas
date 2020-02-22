using System.Collections.Generic;
using subhas.Roles.Dto;
using subhas.Users.Dto;

namespace subhas.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
