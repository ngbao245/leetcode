using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _1009_ComplementOfBase10Integer
    {
        public class Solution
        {
            public int BitwiseComplement(int n)
            {
                if (n == 0) return 1;
                int bitLength = (int)(Math.Log2(n)) + 1;
                int mask = (1 << bitLength) - 1;
                return n ^ mask;
            }
        }
    }
}
