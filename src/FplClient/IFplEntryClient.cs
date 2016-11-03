using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplEntryClient
    {
        Task<FplEventEntry> GetTeam(int teamId, int gameweek);
    }
}