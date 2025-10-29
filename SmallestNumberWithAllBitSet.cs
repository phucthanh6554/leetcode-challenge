namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/smallest-number-with-all-set-bits/?envType=daily-question&envId=2025-10-29
/// </summary>
public class SmallestNumberWithAllBitSet
{
    public int SmallestNumber(int n)
    {
        if (n <= 1)
            return 1;

        var current = 0;
        var number = Math.Pow(2, current) - 1;
        
        while (number < n)
        {
            current += 1;
            number = Math.Pow(2, current) - 1;
        }
        
        return (int)number;
    }
}