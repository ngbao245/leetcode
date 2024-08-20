using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0650_2KeysKeyboard
    {
        public class Solution
        {
            public int MinSteps(int n)
            {
                int count = 0;
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                        count += i;
                    }
                }
                return count;
            }
        }
    }
}
