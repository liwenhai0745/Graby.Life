using System.Threading.Tasks;
using Abp.Application.Services;
using Graby.Life.Sessions.Dto;

namespace Graby.Life.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
