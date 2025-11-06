import pytest
from solution import Solution

@pytest.mark.parametrize("s,expected", [
    (r"()", True),
    (r"()[]{}", True),
    (r"(]", False),
    (r"([])", True),
    (r"([)]", False),
])
def test_isValid_param(s, expected):
    sol = Solution()
    assert sol.isValid(s) == expected
