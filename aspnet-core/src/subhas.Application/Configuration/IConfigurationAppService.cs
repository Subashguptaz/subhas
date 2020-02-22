using System.Threading.Tasks;
using subhas.Configuration.Dto;

namespace subhas.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
