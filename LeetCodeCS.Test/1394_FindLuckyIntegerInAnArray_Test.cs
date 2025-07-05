using LeetCodeCS.MyToy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Test
{
    [TestClass]
    public class _1394_FindLuckyIntegerInAnArray_Test
    {
        [TestMethod]
        public void TestMiddleNode_WithOddNumberOfNodes()
        {
            // Arrange
            var solution = new _1394_FindLuckyIntegerInAnArray.Solution();
            int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            // Act
            int result = solution.FindLucky(arr);

            // Assert
            int expected = 4;
            Assert.AreEqual(expected, result);
        }
    }
}
