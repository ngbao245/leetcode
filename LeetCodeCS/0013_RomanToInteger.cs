namespace LeetCodeCS
{
    public class _0013_RomanToInteger
    {
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        public class Solution
        {
            //public int RomanToInt(string s)
            //{
            //    Dictionary<char, int> map = new Dictionary<char, int>
            //    {
            //        { 'I', 1 },
            //        { 'V', 5 },
            //        { 'X', 10 },
            //        { 'L', 50 },
            //        { 'C', 100 },
            //        { 'D', 500 },
            //        { 'M', 1000 },
            //    };

            //    int res = 0;
            //    int prevValue = 0;

            //    foreach (char c in s)
            //    {
            //        if (map.ContainsKey(c))
            //        {
            //            if (map[c] > prevValue)
            //            {
            //                res += map[c] - prevValue - prevValue;
            //                prevValue = 0;
            //            }
            //            else
            //            {
            //                res += map[c];
            //            }
            //        }
            //        prevValue = map[c];

            //    }
            //    return res;
            //}

            public int RomanToInt(string s)
            {
                Dictionary<char, int> map = new Dictionary<char, int>
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 },
                };

                int total = 0;
                int prevValue = 0;

                foreach (char c in s)
                {
                    int currentValue = map[c];

                    if (currentValue > prevValue)
                    {
                        total += currentValue - 2 * prevValue;
                    }
                    else
                    {
                        total += currentValue;
                    }
                    prevValue = currentValue;
                }
                return total;
            }
        }
    }
}
