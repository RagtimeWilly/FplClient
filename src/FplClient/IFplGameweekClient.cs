using System.Collections.Generic;
using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplGameweekClient
    {
        Task<IEnumerable<FplGameweek>> GetGameweeks();
    }
}
