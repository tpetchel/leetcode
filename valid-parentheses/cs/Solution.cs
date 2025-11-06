public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new();
        foreach (char c in s)
        {
            if (stack.TryPeek(out char top))
            {
                if (AreBalanced(top, c))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        while (stack.TryPop(out char top))
        {
            if (stack.TryPeek(out char next))
            {
                if (AreBalanced(next, top))
                {
                    stack.Pop();
                    continue;
                }
            }
            return false;
        }
        return true;
    }

    private static bool AreBalanced(char c1, char c2) => c1 switch
    {
        '(' => c2 == ')',
        '[' => c2 == ']',
        '{' => c2 == '}',
        _ => false
    };
}
