using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeCS.Tests
{
    [TestClass]
    public class _0049_GroupAnagramsTests
    {
        private readonly _0049_GroupAnagrams.Solution solution = new _0049_GroupAnagrams.Solution();

        [TestMethod]
        public void GroupAnagrams_TestExample1()
        {
            // Arrange
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            // Act
            IList<IList<string>> result = solution.GroupAnagrams(strs);

            // Assert
            Assert.AreEqual(3, result.Count);
            CollectionAssert.AreEquivalent(new List<string> { "eat", "tea", "ate" }, (List<string>)result[0]);
            CollectionAssert.AreEquivalent(new List<string> { "tan", "nat" }, (List<string>)result[1]);
            CollectionAssert.AreEquivalent(new List<string> { "bat" }, (List<string>)result[2]);
        }

        [TestMethod]
        public void GroupAnagrams_TestExample2()
        {
            // Arrange
            string[] strs = new string[] { "" };

            // Act
            IList<IList<string>> result = solution.GroupAnagrams(strs);

            // Assert
            Assert.AreEqual(1, result.Count);
            CollectionAssert.AreEquivalent(new List<string> { "" }, (List<string>)result[0]);
        }

        [TestMethod]
        public void GroupAnagrams_TestExample3()
        {
            // Arrange
            string[] strs = new string[] { "a" };

            // Act
            IList<IList<string>> result = solution.GroupAnagrams(strs);

            // Assert
            Assert.AreEqual(1, result.Count);
            CollectionAssert.AreEquivalent(new List<string> { "a" }, (List<string>)result[0]);
        }

        [TestMethod]
        public void GroupAnagrams_TestEmptyArray()
        {
            // Arrange
            string[] strs = new string[] { };

            // Act
            IList<IList<string>> result = solution.GroupAnagrams(strs);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
