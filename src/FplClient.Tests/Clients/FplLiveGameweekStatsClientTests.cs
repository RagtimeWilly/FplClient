using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    [TestFixture]
    public class FplLiveGameweekStatsClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_player_stats_successfully()
        {
            var result = _context.Sut.Get(1).Result;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Elements.Count > 100);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplLiveGameweekStatsClient(new HttpClient());
            }

            public FplLiveGameweekStatsClient Sut { get; }
        }
    }
}
