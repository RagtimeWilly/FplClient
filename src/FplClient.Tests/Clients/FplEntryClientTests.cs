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
            var teamData = _context.Sut.GetTeam(208476, 1).Result;

            Assert.IsNotNull(teamData);
            Assert.AreEqual(15, teamData.Picks.Count);
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplEntryClient(() => new HttpClient());
            }

            public FplEntryClient Sut { get; }
        }
    }
}
