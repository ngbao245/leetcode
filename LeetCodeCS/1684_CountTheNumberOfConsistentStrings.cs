using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _1684_CountTheNumberOfConsistentStrings
    {
        public class Solution
        {
            public int CountConsistentStrings(string allowed, string[] words)
            {
                int count = words.Length;
                HashSet<char> allowedSet = new HashSet<char>();
                foreach (char c in allowed)
                {
                    allowedSet.Add(c);
                }

                foreach (string s in words)
                {
                    foreach (char c in s)
                    {
                        if (!allowedSet.Contains(c))
                        {
                            count--;
                            break;
                        }
                    }
                }
                return count;
            }
        }
    }
}
