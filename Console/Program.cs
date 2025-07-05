Console.WriteLine(IsPalindrome(123454321));
Console.WriteLine("===============");
Console.WriteLine(IsPalindrome(1000021));
Console.WriteLine("===============");
Console.WriteLine(IsPalindrome(123));

static bool IsPalindrome(int x)
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


