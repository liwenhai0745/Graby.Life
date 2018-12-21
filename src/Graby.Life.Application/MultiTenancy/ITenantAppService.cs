using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Graby.Life.MultiTenancy.Dto;

namespace Graby.Life.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

