using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0217_ContainsDuplicate
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> result = new HashSet<int>(nums);
                return nums.Length != result.Count;

                //Dictionary<int, int> array = new Dictionary<int, int>();
                //for (int i = 0; i < nums.Length; i++)
                //{
                //    if (array.ContainsKey(nums[i]))
                //    {
                //        return true;
                //    }
                //    else
                //    {
                //        array[nums[i]] = 1;
                //    }
                //}
                //return false;
            }
        }
    }
}
