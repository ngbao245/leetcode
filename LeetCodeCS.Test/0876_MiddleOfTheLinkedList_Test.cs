using LeetCodeCS.MyToy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCS.Tests
{
    [TestClass]
    public class _0876_MiddleOfTheLinkedList_Test
    {
        [TestMethod]
        public void TestMiddleNode_WithOddNumberOfNodes()
        {
            // Arrange
            var solution = new _0876_MiddleOfTheLinkedList.Solution();
            var node7 = new ListNode(89);
            var node6 = new ListNode(52, node7);
            var node5 = new ListNode(53, node6);
            var node4 = new ListNode(48, node5);
            var node3 = new ListNode(37, node4);
            var node2 = new ListNode(23, node3);
            var node1 = new ListNode(41, node2);

            // Act
            var middleNode = solution.MiddleNode(node1);

            // Assert
            int position = 0;
            var current = node1;
            while (current != null)
            {
                position++;
                if (current == middleNode)
                {
                    break;
                }
                current = current.next;
            }

            Assert.AreEqual(4, position);
        }
    }
}
