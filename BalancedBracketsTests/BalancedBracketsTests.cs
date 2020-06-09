using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //string[] goodString = { "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]" };

        //string[] badString = { "[LaunchCode", "Launch]Code[", "[", "][" };

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void ReturnEmptyString()
        {
            BalancedBrackets.HasBalancedBrackets("");
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void BracketsAreOrdered()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void MismatchedBrakets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void TooManyBrakets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][][]"));
        }

    }
}
