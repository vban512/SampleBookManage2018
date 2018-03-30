using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMpaMvcEfInit.Sessions.Dto;

namespace AbpMpaMvcEfInit.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
