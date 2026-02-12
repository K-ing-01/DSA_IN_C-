namespace DSA;

internal class Program
{
    private static void Main(string[] args)
    {
        // // List<int> nums = [21, 31, 44, 45, 51, 56, 78, 99];
        // // var key = 51;
        // // // var largest = FindLargest(nums);
        // // // Console.WriteLine(largest);
        // // var index = BinarySearch(nums, key);
        // List<int> nums = [-1, -2, 4, -1, -2, 1, 5, -3];
        // var maxSum = MaximumSubArraySum(nums);
        // Console.WriteLine(maxSum);

        var lt = new LeetCode();
        List<int> nums = [2, 7, 11, 19, 23];
        var target = 9;
        var result = lt.LeetCodeProblems(nums, target);
        Console.WriteLine(string.Join(", ", result));
    }

    private static int FindLargest(List<int> nums)
    {
        var largest = int.MinValue;
        foreach (var num in nums) largest = Math.Max(largest, num);

        return largest;
    }

    private static int BinarySearch(List<int> nums, int key)
    {
        var start = 0;
        var end = nums.Count - 1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2; // avoids overflow

            if (nums[mid] == key)
                return mid;

            if (nums[mid] > key)
                end = mid - 1;
            else
                start = mid + 1;
        }

        return -1;
    }

    public static int MaximumSubArraySum(List<int> nums)
    {
        int currentSum = 0, maxSum = int.MinValue;
        for (var i = 0; i < nums.Count(); i++)
        {
            if (currentSum < 0) currentSum = 0;

            currentSum = currentSum + nums[i];
            maxSum = Math.Max(currentSum, maxSum);
        }

        return maxSum;
    }
}