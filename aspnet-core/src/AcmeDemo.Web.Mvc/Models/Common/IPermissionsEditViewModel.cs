using System.Collections.Generic;
using AcmeDemo.Roles.Dto;

namespace AcmeDemo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}