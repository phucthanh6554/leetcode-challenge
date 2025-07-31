namespace Leetcode.Algorithm;

public class FindFirstLastPositionSortedArray
{
    public int[] SearchRange(int[] nums, int target) {
        // find first index
        var firstIndex = -1;

        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var mid = (start + end) / 2;

            if (nums[mid] == target)
            {
                firstIndex = mid;
                end = mid - 1;
            }
            else if(nums[mid] > target)
                end = mid - 1;
            else
                start = mid + 1;
        }

        if (firstIndex == -1)
            return new int[] { -1, -1 };
        
        // find last index
        start = firstIndex + 1;
        end = nums.Length - 1;
        var lastIndex = -1;

        while (start <= end)
        {
            var mid = (start + end) / 2;

            if (nums[mid] == target)
            {
                lastIndex = mid;
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else 
                start = mid + 1;
        }
        
        if(lastIndex == -1)
            return new int[] { firstIndex, firstIndex };
        
        return new int[] { firstIndex, lastIndex };
    }
}