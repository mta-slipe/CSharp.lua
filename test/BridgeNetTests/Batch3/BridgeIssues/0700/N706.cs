using Bridge.Test.NUnit;
using System;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#706 - {0}")]
    public class Bridge706
    {
        [Field]
        public static object Value
        {
            get;
            set;
        } = 7;

        [Test(ExpectedCount = 1)]
        public static void TestFieldPropertyWithInitializer()
        {
            Assert.AreEqual(7, Bridge706.Value);
        }
    }
}