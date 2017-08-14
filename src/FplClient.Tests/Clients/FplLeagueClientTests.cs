using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    public class FplLeagueClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_classic_league_data_successfully()
        {
            var leagueData = _context.Sut.GetClassicLeague(33).Result;

            Assert.IsNotNull(leagueData);
            Assert.IsTrue(leagueData.Standings.Entries.Count > 0);
        }

        [Test]
        public void Retrieves_classic_league_data_from_next_page_successfully()
        {
            var leagueData = _context.Sut.GetClassicLeague(33, 2).Result;

            Assert.IsNotNull(leagueData);
            Assert.IsTrue(leagueData.Standings.Entries.Count > 0);
        }

        [Test]
        public void Retrieves_head_to_head_league_data_successfully()
        {
            var leagueData = _context.Sut.GetHeadToHeadLeague(751846).Result;

            Assert.IsNotNull(leagueData);
            Assert.IsTrue(leagueData.Standings.Entries.Count > 0);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplLeagueClient(() => new HttpClient());
            }

            public FplLeagueClient Sut { get; }
        }
    }
}
