namespace Leetcode.Algorithm;

public class MaximumSubArrayProblem
{
    public int MaxSubArray(int[] nums) 
    {
        var result = 0;

        var max = int.MinValue;

        foreach (var num in nums)
        {
            if (result + num < num)
                result = num;
            else 
                result += num;
            
            max = Math.Max(max, result);
        }
        
        return max;
    }
}