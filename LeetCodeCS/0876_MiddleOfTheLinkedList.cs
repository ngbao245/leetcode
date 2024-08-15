using LeetCodeCS.MyToy;

namespace LeetCodeCS
{
    public class _0876_MiddleOfTheLinkedList
    {
        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                ListNode middle = head;
                ListNode bottom = head;

                while (bottom != null && bottom.next != null)
                {
                    middle = middle.next;
                    bottom = bottom.next.next;
                }
                return middle;
                
                //List<ListNode> list = new List<ListNode>();
                //int length = 0;
                //while (head != null)
                //{
                //    list.Add(head);
                //    head = head.next;
                //    length++;
                //}
                //return list[length / 2];
            }
        }
    }
}
