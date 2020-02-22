using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using subhas.Roles.Dto;
using subhas.Users.Dto;

namespace subhas.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
