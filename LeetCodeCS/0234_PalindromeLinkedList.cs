using LeetCodeCS.MyToy;

namespace Console
{
    public class _0234_PalindromeLinkedList
    {
        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                if (head == null || head.next == null) return true;

                ListNode slow = head, fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                if (fast != null)
                {
                    slow = slow.next;
                }

                ListNode secondHalf = ReverseList(slow);

                ListNode firstHalf = head;
                while (secondHalf != null)
                {
                    if (firstHalf.val != secondHalf.val) return false;

                    firstHalf = firstHalf.next;
                    secondHalf = secondHalf.next;
                }
                return true;
            }

            private ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                while (head != null)
                {
                    ListNode next = head.next;
                    head.next = prev;
                    prev = head;
                    head = next;
                }
                return prev;
            }
        }
    }
}
