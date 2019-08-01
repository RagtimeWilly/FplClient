using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    [TestFixture]
    public class FplEntryClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_entry_data_successfully()
        {
            var data = _context.Sut.Get(639).Result;

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Leagues.ClassicLeagues.Count > 0);
        }

        [Test, Explicit]
        public void Retrieves_entry_picks_data_successfully()
        {
            var data = _context.Sut.GetPicks(639, 1).Result;

            Assert.IsNotNull(data);
            Assert.AreEqual(15, data.Picks.Count);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplEntryClient(new HttpClient());
            }

            public FplEntryClient Sut { get; }
        }
    }
}
