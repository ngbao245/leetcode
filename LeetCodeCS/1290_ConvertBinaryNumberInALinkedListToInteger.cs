using LeetCodeCS.MyToy;

namespace LeetCodeCS;

public class _1290_ConvertBinaryNumberInALinkedListToInteger
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int count = 0;
            int result = 0;
            string binaryString = string.Empty;

            while (head != null)
            {
                binaryString += head.val.ToString();
                count++;
                head = head.next;
            }

            int temp = count - 1;

            for (int i = 0; i < count; i++)
            {
                if (binaryString[i] == '1')
                {
                    result += (int)Math.Pow(2, temp);
                }
                temp--;
            }
            return result;
        }
    }
}
