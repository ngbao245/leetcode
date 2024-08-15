namespace LeetCodeCS
{
    public class _1672_RichestCustomerWealth
    {
        public class Solution
        {
            public int MaximumWealth(int[][] accounts)
            {
                int maxWealth = 0;
                foreach (int[] account in accounts)
                {
                    int current = 0;
                    foreach (int bank in account)
                    {
                        current += bank;
                    }
                    if (maxWealth < current)
                    {
                        maxWealth = current;
                    }
                }
                return maxWealth;
            }
        }
    }
}
