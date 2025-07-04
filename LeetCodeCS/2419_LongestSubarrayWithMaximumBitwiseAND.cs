namespace LeetCodeCS
{
    public class _2419_LongestSubarrayWithMaximumBitwiseAND
    {
        public class Solution
        {
            public int LongestSubarray(int[] nums) //[1,2,3,3,2,2]
            {
                int biggestCount = 1;
                int biggestNum = -1;
                Dictionary<int, int> pairs = new Dictionary<int, int>();

                for (int i = 1; i < nums.Length; i++)
                {
                    biggestNum = nums[i];
                    if (nums[i] == nums[i - 1])
                    {
                        biggestCount++;

                        if (nums[i] < biggestNum)
                        {
                            biggestNum = nums[i];
                        }
                    }
                    else
                    {
                        if (!pairs.ContainsKey(nums[i]))
                        {
                            pairs.Add(nums[i], biggestCount);
                        }
                        else
                        {
                        }
                        biggestCount = 1;
                    }
                }
                return pairs.Values.Max();
            }
        }
    }
}
