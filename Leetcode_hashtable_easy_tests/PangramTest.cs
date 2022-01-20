using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode_hashtable_easy;

namespace Leetcode_hashtable_easy_tests
{
    [TestClass]
    public class PangramTest
    {
        [TestMethod]
        public void TestValidSentences()
        {
            Pangram p = new Pangram();
            Assert.AreEqual(true,p.CheckIfPangram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void TestInvalidSentences()
        {
            Pangram p = new Pangram();
            Assert.AreEqual(false,p.CheckIfPangram("abdefghijklmnopqrstuvwxyz"));
        }
    }
}
