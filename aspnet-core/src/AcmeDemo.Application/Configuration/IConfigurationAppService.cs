using System.Threading.Tasks;
using AcmeDemo.Configuration.Dto;

namespace AcmeDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
