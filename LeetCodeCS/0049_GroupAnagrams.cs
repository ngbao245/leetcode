namespace LeetCodeCS
{
    public class _0049_GroupAnagrams
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                foreach (string str in strs)
                {
                    char[] c = str.ToCharArray();
                    Array.Sort(c);
                    string sortedStr = new string(c);
                    if (!dict.ContainsKey(sortedStr))
                    {
                        dict.Add(sortedStr, new List<string>());
                    }
                    dict[sortedStr].Add(str);
                }
                return new List<IList<string>>(dict.Values);
            }
        }
    }
}
