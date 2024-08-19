using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    public class _0860_LemonadeChange
    {
        public class Solution
        {
            public bool LemonadeChange(int[] bills)
            {
                Dictionary<int, int> moneys = new Dictionary<int, int>
                {
                    { 5, 0 },
                    { 10, 0 },
                    { 20, 0 }
                };

                foreach (int bill in bills)
                {
                    moneys[bill]++;

                    if (bill == 10)
                    {
                        moneys[5]--;
                        if (moneys[5] < 0)
                        {
                            return false;
                        }
                    }
                    else if (bill == 20)
                    {
                        if (moneys[10] > 0 && moneys[5] > 0)
                        {
                            moneys[10]--;
                            moneys[5]--;
                        }
                        else if (moneys[5] >= 3)
                        {
                            moneys[5] -= 3;
                        }
                        else return false;
                    }

                }
                return true;
            }
        }
    }
}
