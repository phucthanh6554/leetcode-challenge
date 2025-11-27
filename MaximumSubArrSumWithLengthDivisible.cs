namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/maximum-subarray-sum-with-length-divisible-by-k/description/?envType=daily-question&envId=2025-11-27
/// </summary>
public class MaximumSubArrSumWithLengthDivisible
{
    public long MaxSubarraySum(int[] nums, int k)
    {
        var sumPrefix = 0L;
        var minPrefix = new long[k];

        for (int i = 0; i < k; i++)
            minPrefix[i] = long.MaxValue;

        minPrefix[k - 1] = 0;

        long result = long.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sumPrefix += nums[i];

            int mod = i % k;

            if (minPrefix[mod] != long.MaxValue)
                result = Math.Max(result, sumPrefix - minPrefix[mod]);

            minPrefix[mod] = Math.Min(minPrefix[mod], sumPrefix);
        }

        return result;
    }
}