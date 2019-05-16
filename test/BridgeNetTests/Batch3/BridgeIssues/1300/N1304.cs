using Bridge.ClientTestHelper;
using Bridge.Test.NUnit;
using System;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1304 - {0}")]
    public class Bridge1304
    {
        private static string Output
        {
            get
            {
                return Bridge.Utils.Console.Instance.BufferedOutput;
            }

            set
            {
                Bridge.Utils.Console.Instance.BufferedOutput = value;
            }
        }

        [SetUp]
        public static void ClearOutput()
        {
            Output = "";
        }

        [TearDown]
        public static void ResetOutput()
        {
            Output = null;
            Bridge.Utils.Console.Hide();
        }

        [Test]
        public static void TestWriteFormatString()
        {
            Console.Write("{0}", 1);
            Assert.AreEqual("1", Output);
            ClearOutput();

            Console.Write("{0} {1}", 1, 2);
            Assert.AreEqual("1 2", Output);
            ClearOutput();

            Console.Write("{0} {1} {2}", 1, 2, 3);
            Assert.AreEqual("1 2 3", Output);
            ClearOutput();

            Console.Write("{0} {1} {2} {3}", 1, 2, 3, 4);
            Assert.AreEqual("1 2 3 4", Output);
            ClearOutput();

            Console.Write("{0} {1} {2} {3} {4}", 1, 2, 3, 4, "5");
            Assert.AreEqual("1 2 3 4 5", Output);
            ClearOutput();

            Console.Write("{0} {1} {2} {3} {4} {5}", 1, 2, 3, 4, "5", true);
            Assert.AreEqual("1 2 3 4 5 True", Output);
        }

        [Test]
        public static void TestWriteLineFormatString()
        {
            Console.WriteLine("{0}", 1);
            Assert.AreEqual(StringHelper.CombineLinesNL("1"), Output);
            ClearOutput();

            Console.WriteLine("{0} {1}", 1, 2);
            Assert.AreEqual(StringHelper.CombineLinesNL("1 2"), Output);
            ClearOutput();

            Console.WriteLine("{0} {1} {2}", 1, 2, 3);
            Assert.AreEqual(StringHelper.CombineLinesNL("1 2 3"), Output);
            ClearOutput();

            Console.WriteLine("{0} {1} {2} {3}", 1, 2, 3, 4);
            Assert.AreEqual(StringHelper.CombineLinesNL("1 2 3 4"), Output);
            ClearOutput();

            Console.WriteLine("{0} {1} {2} {3} {4}", 1, 2, 3, 4, "5");
            Assert.AreEqual(StringHelper.CombineLinesNL("1 2 3 4 5"), Output);
        }
    }
}