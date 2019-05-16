using Bridge.Test.NUnit;
using System;
using System.Threading.Tasks;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    // Bridge[#930]
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#930 - {0}")]
    public class Bridge930
    {
        private static async Task Test()
        {
            await Task.FromResult(1);
            throw new Exception("test");
        }

        private static async Task Test1()
        {
            var res = true;
            await Task.Delay(1);

            if (res)
            {
                await Test();
            }

            await Task.Delay(1);
        }

        [Test(ExpectedCount = 1)]
        public async static void TestAsyncException()
        {
            var done = Assert.Async();

            try
            {
                await Test1();
                Assert.Fail("await should throw an exception");
            }
            catch (Exception e)
            {
                Assert.AreEqual("test", e.Message);
            }

            done();
        }
    }
}