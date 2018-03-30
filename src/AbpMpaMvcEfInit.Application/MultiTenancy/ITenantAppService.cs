using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpMpaMvcEfInit.MultiTenancy.Dto;

namespace AbpMpaMvcEfInit.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
