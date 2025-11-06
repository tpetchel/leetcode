import pytest
from solution import Solution
from solution import ListNode, toList

@pytest.mark.parametrize("list1,list2,expected", [
    (ListNode(1, ListNode(2, ListNode(4))), ListNode(1, ListNode(3, ListNode(4))), [1, 1, 2, 3, 4, 4]),
    (None, None, []),
    (None, ListNode(0), [0])
])
def test_mergeTwoLists_param(list1, list2, expected):
    sol = Solution()
    merged = sol.mergeTwoLists(list1, list2)
    assert toList(merged) == expected