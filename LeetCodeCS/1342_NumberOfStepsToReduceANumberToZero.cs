namespace LeetCodeCS
{
    public class _1342_NumberOfStepsToReduceANumberToZero
    {
        public class Solution
        {
            public int NumberOfSteps(int num)
            {
                int step = 0;
                while (num > 0)
                {
                    if ((num & 1) > 0)
                    {
                        num--;
                    }
                    else
                    {
                        num >>= 1;
                    }
                    step++;
                }
                return step;
            }

            //public int NumberOfSteps(int num)
            //{
            //    int step = 0;

            //    while (num != 0)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            num = num / 2;
            //        }
            //        else
            //        {
            //            num--;
            //        }
            //        step++;
            //    }
            //    return step;
            //}
        }
    }
}
