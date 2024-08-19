using System.Runtime.ConstrainedExecution;

namespace LeetCodeCS
{
    public class _0001_TwoSum
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    //x = target - cur
                    int current = nums[i]; 
                    int x = target - current;

                    if (map.ContainsKey(x))
                    {
                        return new int[] { map[x], i };
                    }
                    map[current] = i;
                }
                return null;
            }

            //int[] res = new int[2];
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            res[0] = Array.FindIndex(nums, x => x.Equals(nums[i]));
            //            nums[i] = 0;
            //            res[1] = Array.FindIndex(nums, y => y.Equals(nums[j]));
            //            nums[j] = 0;
            //        }
            //    }
            //}
            //return res;
        }
    }
}
