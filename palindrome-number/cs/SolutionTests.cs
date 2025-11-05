using Xunit;
using FluentAssertions;

public class SolutionTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome_Works(int n, bool expected)
    {
        var actual = new Solution().IsPalindrome(n);
        Assert.Equal(expected, actual);
    }
}
