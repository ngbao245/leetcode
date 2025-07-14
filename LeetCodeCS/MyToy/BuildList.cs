namespace LeetCodeCS.MyToy;

public static class BuildList
{
    public static ListNode Build(int[] values)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }
}
