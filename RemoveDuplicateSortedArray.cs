namespace Leetcode.Algorithm;

public class RemoveDuplicateSortedArray
{
    public int RemoveDuplicates(int[] nums) {
        var result = 1;
        
        var currentNumber = nums[0];
        var currentIndex = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > currentNumber)
            {
                nums[currentIndex++] = nums[i];
                result++;
                currentNumber = nums[i];
            }
        }
        return result;
    }
}