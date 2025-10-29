public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        throw new InvalidOperationException("Input must have one solution.");
    }

    // Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    public int[] TwoSum2(int[] nums, int target)
    {
        Dictionary<int, List<int>> m = [];
        m.Add(nums[0], [0]);
        for (int i = 1; i < nums.Length; i++)
        {
            int curr = nums[i];
            int diff = target - curr;
            if (m.TryGetValue(diff, out var candidates))
            {
                return [i, candidates.Single(j => j != i)];
            }
            if (m.TryGetValue(curr, out var indices))
            {
                indices.Add(i);
            }
            else
            {
                indices = [i];
                m[curr] = indices;
            }
        }
        throw new InvalidOperationException("Input must have one solution.");
    }
}