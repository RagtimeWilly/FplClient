using System.Collections.Generic;
using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplFixtureClient
    {
        Task<IEnumerable<FplFixture>> GetFixtures();

        Task<IEnumerable<FplFixture>> GetFixturesByGameweek(int id);
    }
}
