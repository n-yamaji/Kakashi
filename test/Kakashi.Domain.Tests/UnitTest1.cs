using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kakashi.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var 術者 = 術者.登場("カカシ");

            Assert.IsTrue(術者.名前 == "カカシ");
        }
    }
}
