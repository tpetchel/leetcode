import pytest
from solution import Solution

@pytest.mark.parametrize("n,expected", [
    (121, True),
    (-121, False),
    (10, False),
])
def test_isPalindrome_param(n, expected):
    sol = Solution()
    assert sol.isPalindrome(n) == expected
