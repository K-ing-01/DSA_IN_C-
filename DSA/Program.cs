namespace DSA;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = [12, 23, 45, 4];
        var largest = FindLargest(nums);
        Console.WriteLine(largest);
    }

    private static int FindLargest(List<int> nums)
    {
        var largest = int.MinValue;
        foreach (var num in nums) largest = Math.Max(largest, num);

        return largest;
    }
}