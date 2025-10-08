namespace Leetcode.Algorithm;

public class TrappingRainWaterProblem
{
    public int Trap(int[] height)
    {
        if (height.Length <= 1)
            return 0;

        var maxLeft = 0;
        var maxRight = 0;
        var result = 0;

        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= maxLeft)
                {
                    maxLeft = height[left];
                }
                else
                {
                    result += maxLeft - height[left];
                }

                left++;
            }
            else
            {
                if (height[right] >= maxRight)
                {
                    maxRight = height[right];
                }
                else
                {
                    result += maxRight - height[right];
                }

                right--;
            }
        }

        return result;
    }
}