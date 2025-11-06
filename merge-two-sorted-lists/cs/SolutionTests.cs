using System.Collections;
using Xunit;
using FluentAssertions;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {
            new ListNode(1, new ListNode(2, new ListNode(4))),
            new ListNode(1, new ListNode(3, new ListNode(4))),
            new List<int> { 1, 1, 2, 3, 4, 4 }
        };
        yield return new object[]
        {
            (ListNode)null,
            (ListNode)null,
            new List<int>()
        };
        yield return new object[]
        {
            (ListNode)null,
            new ListNode(0),
            new List<int> { 0 }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void MergeTwoLists_Works(ListNode list1, ListNode list2, List<int> expected)
    {
        var actual = new Solution().MergeTwoLists(list1, list2);
        Assert.Equal(expected, actual.ToList());
    }
}
