using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QaflabGhanat.Configuration.Dto;

namespace QaflabGhanat.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QaflabGhanatAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
