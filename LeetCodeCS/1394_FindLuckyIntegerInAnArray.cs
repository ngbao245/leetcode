namespace LeetCodeCS
{
    public class _1394_FindLuckyIntegerInAnArray
    {
        public class Solution
        {
            public int FindLucky(int[] arr)
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (keyValuePairs.ContainsKey(arr[i]))
                    {
                        keyValuePairs[arr[i]]++;
                    }
                    else
                    {
                        keyValuePairs.Add(arr[i], 1);
                    }
                }

                int largestLucky = -1;
                foreach (var kvp in keyValuePairs)
                {
                    if (kvp.Key == kvp.Value && kvp.Key > largestLucky)
                    {
                        largestLucky = kvp.Key;
                    }
                }
                return largestLucky;
            }
        }
    }
}
