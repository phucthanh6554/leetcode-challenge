namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/smallest-missing-non-negative-integer-after-operations/description/?envType=daily-question&envId=2025-10-16
/// </summary>
public class SmallestMissingIntegerAfterOperationProblem
{
    public int FindSmallestInteger(int[] nums, int value)
    {
        var count = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            var mod = ((num % value) + value) % value;

            count.TryAdd(mod, 0);
            count[mod]++;
        }

        var current = 0;

        while (true)
        {
            var mod = current % value;
            var found = count.TryGetValue(mod, out var currentCount);
            
            if(!found || currentCount == 0)
                return current;
            
            count[mod]--;
            current++;
        }

        return current;
    }

    private int BruteForce(int[] nums, int value)
    {
        var used = new bool[nums.Length];
        var remain = nums.Length;

        var current = 0;

        var i = 0;

        while (i < nums.Length && remain > 0)
        {
            if (used[i])
            {
                i++;
                continue;;
            }
            
            if (nums[i] == current)
            {
                used[i] = true;
                current++;
                remain--;
                i = 0;
                continue;
            }
            
            if (!IsValid(nums[i], value, current))
            {
                i++;
                continue;
            }
            
            current++;
            used[i] = true;
            remain--;
            i = 0;
        }

        return current;
    }

    private bool IsValid(double num, double value, int target)
    {
        var x = (target - num) / value;

        return (x - (int)x) == 0;
    }
}