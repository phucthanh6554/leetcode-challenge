namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-i/description/?envType=daily-question&envId=2025-11-04
/// </summary>
public class FindXSumOfAllKLongSubArr
{
    public int[] FindXSum(int[] nums, int k, int x) 
    {
        var result = new int[nums.Length - k + 1];
        
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < k; i++)
        {
            dict.TryAdd(nums[i], 0);
            dict[nums[i]]++;
        }

        for (var i = 0; i <= nums.Length - k; i++)
        {
            if (i != 0)
            {
                dict[nums[i - 1]]--;
                dict.TryAdd(nums[i + k - 1], 0);
                dict[nums[i + k - 1]]++;
            }
            
            var sum = dict
                .OrderByDescending(pair => pair.Value)
                .ThenByDescending(pair => pair.Key)
                .Take(x)
                .Sum(pair => pair.Key * pair.Value);
            
            result[i] = sum;
        }
        
        return result;
    }
}