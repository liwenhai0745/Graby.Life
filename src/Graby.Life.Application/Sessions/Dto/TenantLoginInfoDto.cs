using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Graby.Life.MultiTenancy;

namespace Graby.Life.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
