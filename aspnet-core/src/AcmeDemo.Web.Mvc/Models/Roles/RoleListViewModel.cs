using System.Collections.Generic;
using AcmeDemo.Roles.Dto;

namespace AcmeDemo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
