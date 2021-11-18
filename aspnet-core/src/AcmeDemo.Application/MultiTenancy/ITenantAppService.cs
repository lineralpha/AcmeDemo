using Abp.Application.Services;
using AcmeDemo.MultiTenancy.Dto;

namespace AcmeDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

