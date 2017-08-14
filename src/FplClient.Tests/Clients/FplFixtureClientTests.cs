using System.Linq;
using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    [TestFixture]
    public class FplFixtureClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_fixtures_successfully()
        {
            var data = _context.Sut.GetFixtures().Result;

            Assert.AreEqual(380, data.Count());
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplFixtureClient(() => new HttpClient());
            }

            public FplFixtureClient Sut { get; }
        }
    }
}
