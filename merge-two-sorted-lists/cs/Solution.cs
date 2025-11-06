public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 != null)
        {
            if (list2 != null)
            {
                if (list1.val < list2.val)
                {
                    return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
                }
                else
                {
                    return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
                }
            }
            else
            {
                return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
            }
        }
        else
        {
            if (list2 != null)
            {
                return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
            }
            else
            {
                return null;
            }
        }
    }
}   
