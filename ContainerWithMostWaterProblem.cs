namespace Leetcode.Algorithm;

public class ContainerWithMostWaterProblem
{
    public int MaxArea(int[] height)
    {
        var i = 0;
        var j = height.Length - 1;

        var leftIndex = 0;
        var rightIndex = height.Length - 1;
        
        var maxArea = 0;
        
        while (i < j)
        {
            var area = Math.Min(height[i], height[j]) * (j - i);

            if (area > maxArea)
            {
                maxArea = area;
                leftIndex = i;
                rightIndex = j;
            }

            if (height[i] < height[j])
                i++;
            else
                j--;
        }

        return maxArea;
    }
}