namespace LeetCodeCS
{
    public class _1480_RunningSumOf1DArray
    {
        public class Solution
        {
            public int[] RunningSum(int[] nums)
            {
                // int[] i = new int[nums.Length];
                // int sum = 0;
                // for(int j = 0; j < nums.Length; j++){
                //     sum += nums[j];
                //     i[j] = sum;
                // }
                // return i;

                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] += nums[i - 1];
                }
                return nums;
            }
        }
    }
}
