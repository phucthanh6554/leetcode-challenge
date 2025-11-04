namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/minimum-time-to-make-rope-colorful/?envType=daily-question&envId=2025-11-03
/// </summary>
public class MinimumTimeToMakeRopeColorful
{
    public int MinCost(string colors, int[] neededTime) 
    {
        var totalCost = 0;

        var i = 0;
        var j = 1;

        while (i < colors.Length && j < colors.Length)
        {
            var maxCost = neededTime[i];
            var cost = 0;

            while (j < colors.Length && colors[i] == colors[j])
            {
                maxCost = Math.Max(maxCost, neededTime[j]);
                cost += neededTime[j];
                j++;
            }

            if (cost > 0)
            {
                totalCost += (cost + neededTime[i]) - maxCost;
            }

            i = j;
            j = i + 1;
        }
        
        return totalCost;
    }
}