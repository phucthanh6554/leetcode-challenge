namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/binary-prefix-divisible-by-5/?envType=daily-question&envId=2025-11-24
/// </summary>
public class BinaryPrefixDivisibleByFive
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        var result = new List<bool>(nums.Length);

        byte num = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            num <<= 1;

            num %= 5;
            
            num += (byte) nums[i];
            
            result.Add(num % 5 == 0);
        }
        
        return result;
    }
}