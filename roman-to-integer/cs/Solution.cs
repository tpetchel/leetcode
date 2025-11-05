public class Solution
{
    private static readonly Dictionary<string, int> values = new()
    {
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 },
    };

    public int RomanToInt(string s)
    {
        return RomanToIntAux(s, 0);
    }

    private static int RomanToIntAux(string s, int sum)
    {
        if (s.Length == 0)
        {
            return sum;
        }
        else
        {
            if (values.TryGetValue(string.Concat(s.Take(2)), out int n))
            {
                return RomanToIntAux(string.Concat(s.Skip(2)), sum + n);
            }
            else
            {
                return RomanToIntAux(string.Concat(s.Skip(1)), sum + values[string.Concat(s.Take(1))!]);
            }
        }
    }
}