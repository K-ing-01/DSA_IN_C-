namespace DSA;

public class LeetCode
{
    public int[] LeetCodeProblems(List<int> nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Count; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement)) return new[] { map[complement], i };

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}