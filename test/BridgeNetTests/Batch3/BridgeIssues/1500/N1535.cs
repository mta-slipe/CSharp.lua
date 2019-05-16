using System;
using Bridge.Test.NUnit;

using System.ComponentModel;
using System.Threading.Tasks;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1535 - {0}")]
    public class Bridge1535
    {
        [Test]
        public async void TestAsyncLambdaAssignmentExpression()
        {
            var done = Assert.Async();

            object foo = null;
#pragma warning disable CS1998
            Func<Task<object>> bar = async () => foo = 1;
#pragma warning restore CS1998
            object baz = await bar();
            Assert.AreEqual(1, foo);
            Assert.AreEqual(1, baz);

            done();
        }
    }
}