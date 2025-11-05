using Xunit;
using FluentAssertions;

public class SolutionTests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_Works(string[] strs, string expected)
    {
        var actual = new Solution().LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }
}
