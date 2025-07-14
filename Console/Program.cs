using System;
using LeetCodeCS.MyToy;

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

int[] bits = { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 };
ListNode head = BuildList.Build(bits);


System.Console.WriteLine(GetDecimalValue(head));

static int GetDecimalValue(ListNode head)
{
    int count = 0;
    int result = 0;
    string binaryString = string.Empty;

    while (head != null)
    {
        binaryString += head.val.ToString();
        count++;
        head = head.next;
    }

    int temp = count - 1;

    for (int i = 0; i < count; i++)
    {
        if (binaryString[i] == '1')
        {
            result += (int)Math.Pow(2, temp);
        }
        temp--;
    }
    return result;
}
