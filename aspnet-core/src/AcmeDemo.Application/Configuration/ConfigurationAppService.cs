using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AcmeDemo.Configuration.Dto;

namespace AcmeDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AcmeDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
