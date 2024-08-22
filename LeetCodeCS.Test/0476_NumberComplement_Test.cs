using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _0476_NumberComplement_Test
    {
        private readonly _0476_NumberComplement.Solution solution = new _0476_NumberComplement.Solution();

        [TestMethod]
        public void TestComplementOfFive()
        {
            // Arrange
            int num = 5;
            int expected = 2;

            // Act
            int result = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComplementOfOne()
        {
            // Arrange
            int num = 1;
            int expected = 0;

            // Act
            int result = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComplementOfZero()
        {
            // Arrange
            int num = 0;
            int expected = 1; // Since binary 0 is "0", its complement is "1"

            // Act
            int result = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestComplementOfLargeNumber()
        {
            // Arrange
            int num = 2147483647; // 1111111111111111111111111111111
            int expected = 0;

            // Act
            int result = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
