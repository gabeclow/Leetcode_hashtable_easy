using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode_hashtable_easy;

namespace Leetcode_hashtable_easy_tests
{
    [TestClass]
    public class CountConsistentStringsTest
    {
        [TestMethod]
        public void TestWordInArray()
        {

            string allowed = "SR";
            string[] words = { "AD", "SR3", "ERS", "dSR", "5ER" };
            int output = 2;

            CountConsistentStrings stringsTest = new CountConsistentStrings();
            Assert.AreEqual(output,stringsTest.CountAllConsistentStrings(allowed, words));

        }

        [TestMethod]
        public void TestManyWordsInManyArrays()
        {

            string[] arrAllowed = { "ICIMS", "JW2", "EDW", "IRA" };
            string[][] jaggedArray2 = new string[][]
            {
            new string[] { "ICIMS2", "NO_Match","NC_IR","ICIM" },
            new string[] { "null" ,"JW2" },
            new string[] { "edw", "null", "edw2", "2edw" },
            new string[] { "no value", null }
            };
            int[] output = { 1, 1, 0, 0 };

            CountConsistentStrings stringsTest = new CountConsistentStrings();
            for (int i = 0; i < arrAllowed.Length; i++)
            {
                foreach (var array in jaggedArray2)
                {
                    Assert.AreEqual(output[i],stringsTest.CountAllConsistentStrings(arrAllowed[i], array));
                }
            }


        }
    }
}
