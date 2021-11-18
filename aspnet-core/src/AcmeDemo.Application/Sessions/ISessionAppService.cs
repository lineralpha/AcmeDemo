using System.Threading.Tasks;
using Abp.Application.Services;
using AcmeDemo.Sessions.Dto;

namespace AcmeDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
