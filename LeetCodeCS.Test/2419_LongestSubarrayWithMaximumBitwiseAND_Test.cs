using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _2419_LongestSubarrayWithMaximumBitwiseAND_Test
    {
        private readonly _2419_LongestSubarrayWithMaximumBitwiseAND.Solution solution = new _2419_LongestSubarrayWithMaximumBitwiseAND.Solution();

        [TestMethod]
        public void TestExample1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 3, 2, 2 };
            int expected = 2;

            // Act
            int result = solution.LongestSubarray(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int expected = 1;

            // Act
            int result = solution.LongestSubarray(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAllElementsSame()
        {
            // Arrange
            int[] nums = { 7, 7, 7, 7 };
            int expected = 4;

            // Act
            int result = solution.LongestSubarray(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithMultipleMaxSubarrays()
        {
            // Arrange
            int[] nums = { 311155, 311155, 311155, 311155, 311155, 311155, 311155, 311155, 201191, 311155 };
            int expected = 8;

            // Act
            int result = solution.LongestSubarray(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSingleElementArray()
        {
            // Arrange
            int[] nums = { 8 };
            int expected = 1;

            // Act
            int result = solution.LongestSubarray(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
