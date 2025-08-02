namespace Leetcode.Algorithm;

public class JumpGameProblem
{
    public int Jump(int[] nums)
    {
        var end = 0;
        var maxJump = 0;
        var result = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            maxJump = Math.Max(maxJump, i + nums[i]);

            if (i == end)
            {
                end = maxJump;
                result++;
            }
        }
        
        return result;
    }
}