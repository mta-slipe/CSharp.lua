using Bridge.Test.NUnit;

using System;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    // Bridge[#514]
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#514 - {0}")]
    public class Bridge514
    {
        [Test(ExpectedCount = 2)]
        public static void TestUseCase()
        {
            double d1 = 5.43;
            Assert.AreEqual(1, Math.Sign(d1), "Bridge514 Sign(double 5.43)");

            double d2 = -7.1;
            Assert.AreEqual(-1, Math.Sign(d2), "Bridge514 Sign(double -7.1)");
        }

        [Test(ExpectedCount = 2)]
        public static void TestRelated()
        {
            decimal d1 = 5.43M;
            Assert.AreEqual(1, Math.Sign(d1), "Bridge514 Sign(decimal 5.43)");

            decimal d2 = -7.1M;
            Assert.AreEqual(-1, Math.Sign(d2), "Bridge514 Sign(decimal -7.1)");
        }
    }
}