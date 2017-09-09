using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplEntryClient
    {
        Task<FplBasicEntry> Get(int teamId);

        Task<FplEventEntry> GetEventEntry(int teamId, int gameweek);

        Task<FplEntryPicks> GetPicks(int teamId, int gameweek);
    }
}