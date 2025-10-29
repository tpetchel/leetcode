import pytest
from solution import Solution

@pytest.mark.parametrize("a,b,expected", [
    ([2,7,11,15], 9, [0,1]),
    ([3,2,4], 6, [1,2]),
    ([3,3], 6, [0,1]),
])
def test_twoSum_param(a, b, expected):
    sol = Solution()
    assert sol.twoSum(a, b) == expected

@pytest.mark.parametrize("a,b,expected", [
    ([2,7,11,15], 9, [0,1]),
    ([3,2,4], 6, [1,2]),
    ([3,3], 6, [0,1]),
])
def test_twoSum2_param(a, b, expected):
    sol = Solution()
    res = sol.twoSum2(a, b)
    assert expected[0] in res
    assert expected[1] in res
