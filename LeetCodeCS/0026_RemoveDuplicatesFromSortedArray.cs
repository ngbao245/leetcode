namespace LeetCodeCS
{
    public class _0026_RemoveDuplicatesFromSortedArray
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

                foreach (int num in nums)
                {
                    if (keyValuePairs.ContainsKey(num))
                    {
                        keyValuePairs[num]++;

                    }
                    else
                    {
                        keyValuePairs[num] = 1;
                    }
                }

                for (int i = 0; i < keyValuePairs.Count; i++)
                {
                    nums[i] = keyValuePairs.Keys.ElementAt(i);
                }

                return keyValuePairs.Count;
            }
        }
    }
}
