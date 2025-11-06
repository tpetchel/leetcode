using Xunit;
using FluentAssertions;

public class SolutionTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("([)]", false)]
    public void IsValid_Works(string s, bool expected)
    {
        var actual = new Solution().IsValid(s);
        Assert.Equal(expected, actual);
    }
}
