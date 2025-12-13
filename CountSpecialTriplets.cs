namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/count-special-triplets/?envType=daily-question&envId=2025-12-09
/// </summary>
public class CountSpecialTriplets
{
    public int SpecialTriplets(int[] nums) 
    {
        long result = 0;

        var leftDictionary = new Dictionary<int, int>();
        var rightDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            rightDictionary.TryAdd(nums[i], 0);
            rightDictionary[nums[i]]++;
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            rightDictionary[nums[i]]--;
            
            var num = nums[i] * 2;

            var leftCount = leftDictionary.GetValueOrDefault(num);
            var rightCount = rightDictionary.GetValueOrDefault(num);

            result = (result + ((long)leftCount * rightCount)) % 1_000_000_007;

            leftDictionary.TryAdd(nums[i], 0);
            leftDictionary[nums[i]]++;
        }
        
        return (int)result;
    }
}