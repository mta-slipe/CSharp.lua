using Bridge.Test.NUnit;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    // Bridge[#726]
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#726 - {0}")]
    public class Bridge726
    {
        [Test(ExpectedCount = 1)]
        public static void TestUseCase()
        {
            bool b = true;
            int[] t = new[] { 1, 2, 3 };

            int sum = 0;
            if (b)
                foreach (int i in t)
                    sum += i;

            Assert.AreEqual(6, sum, "Bridge726");
        }
    }
}