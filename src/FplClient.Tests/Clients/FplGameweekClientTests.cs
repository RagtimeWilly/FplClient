using System.Linq;
using System.Net;
using System.Net.Http;
using FplClient.Clients;
using NUnit.Framework;

namespace FplClient.Tests.Clients
{
    [TestFixture]
    public class FplGameweekClientTests
    {
        private TestContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new TestContext();
        }

        [Test]
        public void Retrieves_gameweeks_successfully()
        {
            var data = _context.Sut.GetGameweeks().Result;

            Assert.AreEqual(38, data.Count());
        }

        private class TestContext
        {
            public TestContext()
            {
                Sut = new FplGameweekClient(new HttpClient());
            }

            public FplGameweekClient Sut { get; }
        }
    }
}
