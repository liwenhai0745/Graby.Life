using System.Threading.Tasks;
using Abp.Application.Services;
using Graby.Life.Authorization.Accounts.Dto;

namespace Graby.Life.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
