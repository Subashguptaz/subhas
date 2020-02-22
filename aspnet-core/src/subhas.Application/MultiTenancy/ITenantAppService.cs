using Abp.Application.Services;
using Abp.Application.Services.Dto;
using subhas.MultiTenancy.Dto;

namespace subhas.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

