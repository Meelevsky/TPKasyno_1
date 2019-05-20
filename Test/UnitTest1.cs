using NUnit.Framework;
using TPKasyno_1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var dr = new DataRepository(new WypelnianieStalymi());

            var a = dr.GetKatalog("dupa");
            Assert.Pass();
        }
    }
}