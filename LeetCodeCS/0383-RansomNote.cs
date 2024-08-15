namespace LeetCodeCS
{
    public class _0383_RansomNote
    {
        public class Solution
        {
            public bool CanConstruct(string ransomNote, string magazine)
            {
                Dictionary<char, int> magazineLetter = new Dictionary<char, int>();

                for (int i = 0; i < magazine.Length; i++)
                {
                    char m = magazine[i];

                    if (magazineLetter.ContainsKey(m))
                    {
                        magazineLetter[m]++;
                    }
                    else
                    {
                        magazineLetter[m] = 1;
                    }
                }

                for (int i = 0; i < ransomNote.Length; i++)
                {
                    char r = ransomNote[i];
                    if (magazineLetter.ContainsKey(r) && magazineLetter[r] > 0)
                    {
                        magazineLetter[r]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;


                //string res = "";

                //foreach (char r in ransomNote)
                //{
                //    foreach (var m in magazine)
                //    {
                //        int pos = -1;
                //        if (m == r)
                //        {
                //            pos = magazine.IndexOf(m);
                //            magazine = magazine.Substring(0, pos) + magazine.Substring(pos + 1);
                //            res += r;

                //            if (res == ransomNote)
                //            {
                //                return true;
                //            }
                //            break;
                //        }
                //    }
                //}
                //return false;
            }
        }
    }
}
