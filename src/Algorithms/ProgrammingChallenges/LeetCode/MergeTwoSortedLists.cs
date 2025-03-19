namespace ProgrammingChallenges.LeetCode;

public static class MergeTwoSortedLists
{
    /*
    You are given the heads of two sorted linked lists list1 and list2.

    Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

    Return the head of the merged linked list. 
     */
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new(-1);
        ListNode listNode = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.Val <= list2.Val)
            {
                listNode.Next = list1;
                list1 = list1.Next;
            }
            else
            {
                listNode.Next = list2;
                list2 = list2.Next;
            }
            listNode = listNode.Next;
        }

        if (list1 != null)
        {
            listNode.Next = list1;
        }
        else
        {
            listNode.Next = list2;
        }

        return dummy.Next;
    }
}
