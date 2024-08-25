using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]

    public class Test_css
    {
        [Test]
        public void Test1()
        {

            string Actual = "a";
            string Expected = "a";
            ClassicAssert.AreEqual(Expected, Actual);

        }
    }
}
