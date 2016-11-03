using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    [TestFixture]
    public class FplEntryHistoryClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_team_history_successfully()
        {
            var data = _context.Sut.GetHistory(208476).Result;

            Assert.IsNotNull(data);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplEntryHistoryClient(() => new HttpClient());
            }

            public FplEntryHistoryClient Sut { get; }
        }
    }
}
