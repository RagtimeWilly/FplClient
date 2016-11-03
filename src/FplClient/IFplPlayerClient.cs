using System.Collections.Generic;
using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplPlayerClient
    {
        Task<IEnumerable<FplPlayer>> GetAllPlayers();

        Task<FplPlayerSummary> GetPlayer(int playerId);
    }
}