namespace Leetcode.Algorithm;

public class JumpGamePossibleProblem
{
    public bool CanJump(int[] nums)
    {
        var maxReach = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if(i > maxReach)
                return false;
            
            maxReach = Math.Max(maxReach, nums[i] + i);
        }
        
        return true;
    }
}