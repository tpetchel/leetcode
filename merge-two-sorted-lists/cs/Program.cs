var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
var merged = new Solution().MergeTwoLists(list1, list2);
Console.WriteLine($"[{string.Join(',', merged.ToList())}]");