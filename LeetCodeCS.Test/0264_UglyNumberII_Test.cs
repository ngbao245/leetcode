using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _0264_UglyNumberII_Test
    {
        [TestMethod]
        public void TestNthUglyNumber_Case1()
        {
            // Arrange
            var solution = new _0264_UglyNumberII.Solution();
            int n = 10;
            int expected = 12;

            // Act
            int result = solution.NthUglyNumber(n);

            // Assert
            Assert.AreEqual(expected, result, $"The {n}th ugly number should be {expected}.");
        }

        [TestMethod]
        public void TestNthUglyNumber_Case2()
        {
            // Arrange
            var solution = new _0264_UglyNumberII.Solution();
            int n = 1;
            int expected = 1;

            // Act
            int result = solution.NthUglyNumber(n);

            // Assert
            Assert.AreEqual(expected, result, $"The {n}th ugly number should be {expected}.");
        }
    }
}
