using System.Collections.Generic;
using AcmeDemo.Roles.Dto;

namespace AcmeDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
