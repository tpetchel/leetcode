public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var digits = Digits(x);
        int len = digits.Length;
        for (int i = 0; i < len; i++)
        {
            if (digits[i] != digits[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    private static int[] Digits(int n)
    {
        List<int> digits = [];
        while (n > 0)
        {
            digits.Add(n % 10);
            n /= 10;
        }
        return [.. digits];
    }
}
