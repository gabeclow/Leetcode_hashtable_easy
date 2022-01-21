using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode_hashtable_easy;

namespace Leetcode_hashtable_easy_tests
{
    [TestClass]
    public class TestTemplate
    {
        [TestMethod]
        public void Test1()
        {
            Pangram p = new Pangram();
            Assert.AreEqual(true, p.CheckIfPangram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void Test2()
        {
            Pangram p = new Pangram();
            Assert.AreEqual(false, p.CheckIfPangram("abdefghijklmnopqrstuvwxyz"));
        }
    }
}