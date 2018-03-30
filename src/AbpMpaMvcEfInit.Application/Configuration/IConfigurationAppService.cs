using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMpaMvcEfInit.Configuration.Dto;

namespace AbpMpaMvcEfInit.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}