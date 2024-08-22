using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0476_NumberComplement
    {
        public class Solution
        {
            public int FindComplement(int num)
            {
                if (num == 0) return 1;

                int temp = num;
                int bitLength = 0;
                while (temp > 0)
                {
                    temp >>= 1;
                    bitLength++;
                }

                int mask = (1 << bitLength) - 1;

                return num ^ mask;

                //if (num == 0) return 1;
                //int bitLength = (int)Math.Floor(Math.Log2(num)) + 1;
                //int mask = (1 << bitLength) - 1;
                //return num ^ mask;
            }
        }
    }
}
