namespace LeetCodeCS
{
    public class _0009_PalindromeNumber
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                for (int i = 0; i < x.ToString().Length; i++)
                {
                    for (int j = x.ToString().Length - (i + 1); j >= 0; j--)
                    {
                        if (x.ToString()[i] == x.ToString()[j])
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
