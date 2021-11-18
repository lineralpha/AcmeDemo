using System.Threading.Tasks;
using Abp.Application.Services;
using AcmeDemo.Authorization.Accounts.Dto;

namespace AcmeDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
