using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplGlobalSettingsClient
    {
        Task<FplGlobalSettings> GetGlobalSettings();
    }
}
