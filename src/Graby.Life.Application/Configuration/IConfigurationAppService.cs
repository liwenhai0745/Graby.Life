using System.Threading.Tasks;
using Graby.Life.Configuration.Dto;

namespace Graby.Life.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
