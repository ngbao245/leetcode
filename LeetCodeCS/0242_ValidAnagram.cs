using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0242_ValidAnagram
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length) return false;

                int[] count = new int[26];

                for (int i = 0; i < s.Length; i++) //ASCII a=61
                {
                    count[s[i] - 'a']++; //a=61 c=63 => c-a=2 => count = [0,0,1,...,0]
                    count[t[i] - 'a']--;
                }

                foreach (int i in count)
                {
                    if (i != 0)
                    {
                        return false;
                    }
                }
                return true;

                //    Dictionary<char, int> words = new Dictionary<char, int>();

                //    if (s.Length != t.Length) return false;

                //    foreach (char word in s)
                //    {
                //        if (words.ContainsKey(word))
                //        {
                //            words[word]++;
                //        }
                //        else
                //        {
                //            words[word] = 1;
                //        }
                //    }

                //    foreach (char wordT in t)
                //    {
                //        if (words.ContainsKey(wordT))
                //        {
                //            words[wordT]--;
                //        }
                //        else return false;
                //    }

                //    foreach (int count in words.Values)
                //    {
                //        if (count != 0)
                //        {
                //            return false;
                //        }
                //    }
                //    return true;
            }
        }
    }
}
