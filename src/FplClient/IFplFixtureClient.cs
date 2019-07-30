using System.Collections.Generic;
using System.Threading.Tasks;
using FplClient.Data;

namespace FplClient
{
    public interface IFplFixtureClient
    {
        Task<ICollection<FplFixture>> GetFixtures();

        Task<ICollection<FplFixture>> GetFixturesByGameweek(int id);
    }
}
