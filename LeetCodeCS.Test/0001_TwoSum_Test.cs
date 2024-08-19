using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _0001_TwoSum_Test
    {
        [TestMethod]
        public void TwoSum_TestCase1()
        {
            // Arrange
            var solution = new _0001_TwoSum.Solution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoSum_TestCase2()
        {
            // Arrange
            var solution = new _0001_TwoSum.Solution();
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoSum_TestCase3()
        {
            // Arrange
            var solution = new _0001_TwoSum.Solution();
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoSum_TestCase4()
        {
            // Arrange
            var solution = new _0001_TwoSum.Solution();
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;
            int[] expected = { 2, 4 };

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}

