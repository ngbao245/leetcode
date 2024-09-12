using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _1684_CountTheNumberOfConsistentStrings_Test
    {
        private readonly _1684_CountTheNumberOfConsistentStrings.Solution solution = new _1684_CountTheNumberOfConsistentStrings.Solution();

        [TestMethod]
        public void TestCountConsistentStrings1()
        {
            string allowed = "ab";
            string[] words = { "ad", "bd", "aaab", "baa", "badab" };
            int result = solution.CountConsistentStrings(allowed, words); 
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCountConsistentStrings2()
        {
            string allowed = "abc";
            string[] words = { "a", "b", "c", "ab", "ac", "bc", "abc" };
            int result = solution.CountConsistentStrings(allowed, words);  
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestCountConsistentStrings3()
        {
            string allowed = "cad";
            string[] words = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
            int result = solution.CountConsistentStrings(allowed, words); 
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestCountConsistentStrings4()
        {
            string allowed = "fstqyienx";
            string[] words = { "n", "eeitfns", "eqqqsfs", "i", "feniqis", "lhoa", "yqyitei", "sqtn", "kug", "z", "neqqis" };
            int result = solution.CountConsistentStrings(allowed, words);  
            Assert.AreEqual(8, result);
        }
    }
}
