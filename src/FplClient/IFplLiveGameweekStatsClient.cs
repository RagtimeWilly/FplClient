using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplLiveGameweekStatsClient
    {
        Task<FplLiveGameweekStats> Get(int gameweek);
    }
}
