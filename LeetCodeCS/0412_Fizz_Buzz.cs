using System.Collections;

namespace LeetCodeCS
{
    public class _0412_Fizz_Buzz
    {
        public class Solution
        {
            public IList<String> FizzBuzz(int n)
            {
                List<String> result = new List<String>();

                for (int i = 1; i <= n; i++)
                {
                    String currentStr = "";
                    bool divBy3 = i % 3 == 0;
                    bool divBy5 = i % 5 == 0;

                    if (divBy3)
                    {
                        currentStr += "Fizz";
                    }
                    if (divBy5)
                    {
                        currentStr += "Buzz";
                    }
                    if (String.IsNullOrEmpty(currentStr))
                    {
                        currentStr = i.ToString();
                    }
                    result.Add(currentStr);

                    //if (i % 3 != 0 && i % 5 != 0)
                    //{
                    //    list.Add(i.ToString());
                    //}
                    //else if (i % 3 == 0 && i % 5 == 0)
                    //{
                    //    list.Add("FizzBuzz");
                    //}
                    //else if (i % 5 == 0)
                    //{
                    //    list.Add("Buzz");
                    //}
                    //else if (i % 3 == 0)
                    //{
                    //    list.Add("Fizz");
                    //}
                }
                return result;
            }
        }
    }
}
