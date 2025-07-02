namespace Leetcode.Algorithm;

public class RemoveElementProblem
{
    public int RemoveElement(int[] nums, int val)
    {
        var result = 0;

        var currentIndex = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[currentIndex] = nums[i];
                currentIndex++;
                result++;
            }
        }
        
        return result;
    }
}