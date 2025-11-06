public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class ListNodeUtils
{
    public static List<int> ToList(this ListNode node)
    {
        if (node == null)
        {
            return [];
        }
        else if (node.next != null)
        {
            List<int> a = [node.val];
            List<int> b = ToList(node.next);
            return [.. a, .. b];
        }
        else
        {
            return [node.val];
        }
    }
}