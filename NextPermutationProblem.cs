namespace Leetcode.Algorithm;

public class NextPermutationProblem
{
    public void NextPermutation(int[] nums)
    {
        int pivotIndex = -1;

        for (var i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                pivotIndex = i - 1;
                break;
            }
        }

        if (pivotIndex == -1)
        {
            Array.Sort(nums);
            return;
        }

        for (var i = nums.Length - 1; i > pivotIndex; i--)
        {
            if (nums[i] > nums[pivotIndex])
            {
                (nums[pivotIndex], nums[i]) = (nums[i], nums[pivotIndex]);
                break;
            }
        }
        
        var start = pivotIndex + 1;
        var end = nums.Length - 1;

        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}