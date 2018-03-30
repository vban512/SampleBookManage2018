using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpMpaMvcEfInit.Configuration.Dto;

namespace AbpMpaMvcEfInit.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpMpaMvcEfInitAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
