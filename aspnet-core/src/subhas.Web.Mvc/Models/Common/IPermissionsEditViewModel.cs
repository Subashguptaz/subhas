using System.Collections.Generic;
using subhas.Roles.Dto;

namespace subhas.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}