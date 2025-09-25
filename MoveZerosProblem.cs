namespace Leetcode.Algorithm;

public class MoveZerosProblem
{
    public void MoveZeroes(int[] nums)
    {
        var index = 0;

        foreach (var num in nums)
        {
            if(num != 0)
                nums[index++] = num;
        }
        
        for(var i = index; i < nums.Length; i++)
            nums[i] = 0;
    }
}