namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/minimum-number-of-increments-on-subarrays-to-form-a-target-array/?envType=daily-question&envId=2025-10-30
/// </summary>
public class MinimumNumberOfIncrementToFormTarget
{
    public int MinNumberOperations(int[] target)
    {
        var result = target[0];

        for (var i = 1; i < target.Length; i++)
        {
            if(target[i] > target[i - 1])
                result += target[i] - target[i - 1];
        }
        
        return result;
    }

    private static int MyFirstStupidSolution(int[] target)
    {
        var tempArr = new int[target.Length];
        
        var i = 0;

        var result = 0;

        while (i < target.Length)
        {
            if (tempArr[i] >= target[i])
            {
                i++;
                continue;
            }

            var j = i;
            
            var minStep = int.MaxValue;

            while (j < target.Length && tempArr[j] < target[j])
            {
                minStep = Math.Min(minStep, target[j] - tempArr[j]);
                j++;
            }

            for (var k = i; k < j; k++)
                tempArr[k] += minStep;

            result += minStep;
        }
        
        return result;
    }
}