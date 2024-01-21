using System.Threading.Tasks;
using QaflabGhanat.Configuration.Dto;

namespace QaflabGhanat.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
