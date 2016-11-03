using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplLeagueClient
    {
        Task<FplClassicLeague> GetClassicLeague(int leagueId, int? page = null);

        Task<FplHeadToHeadLeague> GetHeadToHeadLeague(int leagueId);
    }
}