using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplEntryHistoryClient
    {
        Task<FplEntryHistory> GetHistory(int teamId);
    }
}