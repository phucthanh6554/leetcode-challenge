namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/make-array-elements-equal-to-zero/?envType=daily-question&envId=2025-10-28
/// </summary>
public class MakeArrayElementsEqualToZeroProblem
{
    public enum Direction
    {
        Left,
        Right
    }
    
    public int CountValidSelections(int[] nums)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if(IsValidSelection(nums, i, Direction.Left))
                    result += 1;
                
                if(IsValidSelection(nums, i, Direction.Right))
                    result += 1;
            }
        }
        
        return result;
    }

    private bool IsValidSelection(int[] nums, int startIndex, Direction direction)
    {
        var arr = nums.ToArray();

        while (startIndex >= 0 && startIndex < arr.Length)
        {
            if (arr[startIndex] > 0)
            {
                arr[startIndex]--;
                
                direction = direction == Direction.Right ? Direction.Left : Direction.Right;
            }
            
            if (direction == Direction.Right)
                startIndex++;
            else
                startIndex--;
        }
        
        return arr.All(x => x == 0);
    }
}