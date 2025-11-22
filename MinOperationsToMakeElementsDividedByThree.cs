namespace Leetcode.Algorithm;

public class MinOperationsToMakeElementsDividedByThree
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three/description/?envType=daily-question&envId=2025-11-22
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinimumOperations(int[] nums)
    {
        var min = 0;

        foreach (var num in nums)
        {
            if (num % 3 != 0)
                min++;
        }
        
        return min;
    }
}