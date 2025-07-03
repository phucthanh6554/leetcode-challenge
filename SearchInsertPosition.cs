namespace Leetcode.Algorithm;

public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        if (target < nums[0])
            return 0;
        
        if(target > nums[^1])
            return nums.Length;

        var start = 0;
        var end = nums.Length - 1;

        int mid = 0;

        // 1, 3, 5, 6 ; 2
        while (start < end)
        {
            mid = (start + end) / 2;
            
            if (nums[mid] == target)
                return mid;
            
            if (target < nums[mid])
            {
                end = mid;
            }
            else
            {
                start = mid + 1;
            }
        }

        return end;
    }
}