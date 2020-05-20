using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace FormTest
{
    [TestClass]
    public class TestForm2
    {
        [TestMethod]
        public void PlnToUsd_Test()
        {
            Count cnt = new Count();
            cnt.temp = 412;
            Assert.AreEqual(cnt.PlnToUSD(), 100, 0.0001);
        }
        [TestMethod]
        public void PlnToEUR_Test()
        {
            Count cnt = new Count();
            cnt.temp = 452;
            Assert.AreEqual(cnt.PlnToEUR(), 100, 0.0001);
        }
        [TestMethod]
        public void UsdToPln_Test()
        {
            Count cnt = new Count();
            cnt.temp = 100;
            Assert.AreEqual(cnt.UsdToPln(), 412, 0.0001);
        }
        [TestMethod]
        public void UsdToEUR_Test()
        {
            Count cnt = new Count();
            cnt.temp = 100;
            Assert.AreEqual(cnt.UsdToEUR(), 91, 0.0001);
        }
        [TestMethod]
        public void EURToUsd_Test()
        {
            Count cnt = new Count();
            cnt.temp = 91;
            Assert.AreEqual(cnt.EURToUsd(), 100, 0.0001);
        }
        [TestMethod]
        public void EURToPln_Test()
        {
            Count cnt = new Count();
            cnt.temp = 100;
            Assert.AreEqual(cnt.EURToPln(), 452, 0.0001);
        }
    }
}
