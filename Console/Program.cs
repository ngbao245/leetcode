using LeetCodeCS.MyToy;

System.Console.WriteLine(IsValid("IS"));

static bool IsValid(string word)
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



//ListNode head = new ListNode(1,
//                    new ListNode(2,
//                        new ListNode(3,
//                            new ListNode(4,
//                                new ListNode(3,
//                                    new ListNode(2,
//                                        new ListNode(1)
//                                    )
//                                )
//                            )
//                        )
//                    )
//                );

//int[] bits = { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 };
//ListNode head = BuildList.Build(bits);


//System.Console.WriteLine(GetDecimalValue(head));

//static int GetDecimalValue(ListNode head)
//{
//    int count = 0;
//    int result = 0;
//    string binaryString = string.Empty;

//    while (head != null)
//    {
//        binaryString += head.val.ToString();
//        count++;
//        head = head.next;
//    }

//    int temp = count - 1;

//    for (int i = 0; i < count; i++)
//    {
//        if (binaryString[i] == '1')
//        {
//            result += (int)Math.Pow(2, temp);
//        }
//        temp--;
//    }
//    return result;
//}
