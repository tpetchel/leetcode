import pytest
from solution import Solution

@pytest.mark.parametrize("strs,expected", [
    (["flower","flow","flight"], "fl"),
    (["dog","racecar","car"], "")
])
def test_longestCommonPrefix_param(strs, expected):
    sol = Solution()
    assert sol.longestCommonPrefix(strs) == expected
