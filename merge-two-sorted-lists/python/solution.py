from typing import List
from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def toList(node: Optional[ListNode]) -> List[int]:
    if node is None:
        return []
    elif node.next is not None:
        return [node.val] + toList(node.next)
    else:
        return [node.val]

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if list1 is not None:
            if list2 is not None:
                if list1.val < list2.val:
                    return ListNode(list1.val, self.mergeTwoLists(list1.next, list2))
                else:
                    return ListNode(list2.val, self.mergeTwoLists(list1, list2.next))
            else:
                return ListNode(list1.val, self.mergeTwoLists(list1.next, list2))
        else:
            if list2 is not None:
                return ListNode(list2.val, self.mergeTwoLists(list1, list2.next))
            else:
                return None

if __name__ == "__main__":
    list1 = ListNode(1, ListNode(2, ListNode(4)))
    list2 = ListNode(1, ListNode(3, ListNode(4)))
    merged = Solution().mergeTwoLists(list1, list2)
    print(f"[{toList(merged)}]")
