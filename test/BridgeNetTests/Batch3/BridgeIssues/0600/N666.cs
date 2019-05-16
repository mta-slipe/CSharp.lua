using Bridge.Test.NUnit;
using System;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    // Bridge[#666]
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#666 - {0}")]
    public class Bridge666
    {
        [Test(ExpectedCount = 1)]
        public static void TestUseCase()
        {
            Assert.AreEqual(360, GetSum(), "Bridge666 GetSum 360");
        }

        private static int GetSum()
        {
            var sum = 0;
            int[] numbers = { 1, 2, 3 };

            foreach (var n in numbers)
            {
                Action<int> func = (int i) =>
                {
                    int[] bigNumbers = { 10, 20, 30 };
                    foreach (var bn in bigNumbers)
                    {
                        sum = sum + i * bn;
                    }
                };

                func(n);
            }

            return sum;
        }
    }
}