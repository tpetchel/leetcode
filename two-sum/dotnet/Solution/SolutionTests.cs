using Xunit;
using FluentAssertions;

public class SolutionTests {
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_Works(int[] nums, int target, int[] expected)
    {
        var actual = new Solution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum2_Works(int[] nums, int target, int[] expected)
    {
        var actual = new Solution().TwoSum2(nums, target);
        actual.Should().Contain(expected[0]);
        actual.Should().Contain(expected[1]);
    }
}