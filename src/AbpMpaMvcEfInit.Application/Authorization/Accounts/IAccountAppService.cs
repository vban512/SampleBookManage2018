using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMpaMvcEfInit.Authorization.Accounts.Dto;

namespace AbpMpaMvcEfInit.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
