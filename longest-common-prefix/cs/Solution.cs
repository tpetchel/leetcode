using System.Text;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int shortest = strs.Min(s => s.Length);
        StringBuilder sb = new();
        string first = strs[0];
        for (int i = 0; i < shortest; i++)
        {
            if (!strs.All(s => s[i] == first[i]))
            {
                break;
            }
            sb.Append(first[i]);
        }
        return sb.ToString();
    }
}