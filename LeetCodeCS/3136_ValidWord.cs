namespace LeetCodeCS;

public class _3136_ValidWord
{
    public class Solution
    {
        public bool IsValid(string word)
        {
            int vowels = 0;
            int count = 0;
            bool res = true;
            int consonant = 0;
            foreach (char c in word)
            {
                if ((char)c.ToString().ToLower().First() == (char)c.ToString().ToLower().First())
                {
                    count++;
                }
            }

            foreach (char c in word)
            {
                if (!((c >= 48 && c <= 57) || (c >= 65 && c <= 90) || (c >= 97 && c <= 122)))
                {
                    res = false;
                }
            }

            foreach (char c in word)
            {
                if ((char)c.ToString().ToLower().First() == 'a' || (char)c.ToString().ToLower().First() == 'e' ||
                                (char)c.ToString().ToLower().First() == 'i' || (char)c.ToString().ToLower().First() == 'o' ||
                                (char)c.ToString().ToLower().First() == 'u')
                {
                    vowels++;
                    if (count >= 3 && res && consonant > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    if (!(c >= 48 && c <= 57)) consonant++;
                }
            }

            if (consonant == 0) res = false;

            if (count < 3 || vowels == 0) return false;
            return res;
        }
    }
}
