using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Graby.Life.Roles.Dto;
using Graby.Life.Users.Dto;

namespace Graby.Life.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
