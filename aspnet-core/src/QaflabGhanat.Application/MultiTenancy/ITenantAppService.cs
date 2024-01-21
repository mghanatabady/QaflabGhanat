using Abp.Application.Services;
using QaflabGhanat.MultiTenancy.Dto;

namespace QaflabGhanat.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

