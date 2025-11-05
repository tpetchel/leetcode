import pytest
from solution import Solution

@pytest.mark.parametrize("s,expected", [
    ("III", 3),
    ("LVIII", 58),
    ("MCMXCIV", 1994),
])
def test_romanToInt_param(s, expected):
    sol = Solution()
    assert sol.romanToInt(s) == expected
