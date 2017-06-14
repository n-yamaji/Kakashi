using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kakashi.Domain.Art;

namespace Kakashi.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 名づけは正しいか()
        {
            var _ = 術者.登場("hoge");
            Assert.AreEqual(_.名前, "hoge");
        }

        [TestMethod]
        public void コピーできてるか()
        {
            var _ = 術.新術(
                術名.命名("hogehogeの術"), 
                印.組む("hoge"));

            var __ = 術者.登場("fuga");
            Assert.AreEqual<int>(__.使える術.Count, 0);

            __.コピー(_);

            Assert.AreEqual<int>(__.使える術.Count,1);
        }
    }
}
