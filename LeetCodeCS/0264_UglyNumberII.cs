using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0264_UglyNumberII
    {
        public class Solution
        {
            public int NthUglyNumber(int n)
            {
                int[] ugly = new int[n];
                ugly[0] = 1;
                int p2 = 0, p3 = 0, p5 = 0;

                if (n > 1)
                {
                    for (int i = 1; i < n; i++)
                    {
                        int nextUgly2 = ugly[p2] * 2;
                        int nextUgly3 = ugly[p3] * 3;
                        int nextUgly5 = ugly[p5] * 5;

                        if (nextUgly2 <= nextUgly3 && nextUgly2 <= nextUgly5)
                        {
                            ugly[i] = nextUgly2;
                        }
                        else if (nextUgly3 <= nextUgly2 && nextUgly3 <= nextUgly5)
                        {
                            ugly[i] = nextUgly3;
                        }
                        else
                        {
                            ugly[i] = nextUgly5;
                        }

                        if (ugly[i] == nextUgly2)
                        {
                            p2++;
                        }
                        if (ugly[i] == nextUgly3)
                        {
                            p3++;
                        }
                        if (ugly[i] == nextUgly5)
                        {
                            p5++;
                        }
                    }
                    return ugly[n - 1];
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
