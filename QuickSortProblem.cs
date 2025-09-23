namespace Leetcode.Algorithm;

public class QuickSortProblem
{
    public void Sort(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
    }

    private void QuickSort(int[] nums, int left, int right)
    {
        if (left >= right)
            return;
        
        var pivot = Partition(nums, left, right);
        QuickSort(nums, left, pivot - 1);
        QuickSort(nums, pivot + 1, right);
    }

    private int Partition(int[] nums, int left, int right)
    {
        var pivot = nums[right];
        var i = left - 1;
        var j = left;

        while (j < right)
        {
            if (nums[j] < pivot)
            {
                i += 1;
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }

            j++;
        }

        i += 1;
        (nums[i], nums[j]) = (nums[j], nums[i]);
        return i;
    }
}