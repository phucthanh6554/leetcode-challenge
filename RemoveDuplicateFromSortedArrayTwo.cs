namespace Leetcode.Algorithm;

public class RemoveDuplicateFromSortedArrayTwo
{
    public int RemoveDuplicates(int[] nums) 
    {
        if(nums.Length <= 2)
            return nums.Length;

        var currentNum = nums[0];
        var index = 1;
        var flag = false;

        var resultLength = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != currentNum)
            {
                nums[index++] = nums[i];
                currentNum = nums[i];
                flag = false;
                resultLength += 1;
            }
            else if (nums[i] == currentNum && !flag)
            {
                flag = true;
                resultLength += 1;
                nums[index++] = nums[i];
            }
        }
        
        return resultLength;
    }
}