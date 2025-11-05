using Xunit;
using FluentAssertions;

public class SolutionTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_Works(string s, int expected)
    {
        var actual = new Solution().RomanToInt(s);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt2_Works(string s, int expected)
    {
        var actual = new solution2.Solution().RomanToInt(s);
        Assert.Equal(expected, actual);
    }
}
