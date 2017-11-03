using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplGlobalSettings
    {
        Task<FplGlobalSettings> GetGlobalSettings();
    }
}
