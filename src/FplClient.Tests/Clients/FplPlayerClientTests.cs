using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    public class FplPlayerClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_all_players_successfully()
        {
            var playerData = _context.Sut.GetAllPlayers().Result;

            Assert.IsNotNull(playerData);
        }

        [Test]
        public void Retrieves_all_player_summary_successfully()
        {
            var playerData = _context.Sut.GetPlayer(54).Result;

            Assert.IsNotNull(playerData);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplPlayerClient(new HttpClient());
            }

            public FplPlayerClient Sut { get; }
        }
    }
}
