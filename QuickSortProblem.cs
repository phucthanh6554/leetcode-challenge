namespace Leetcode.Algorithm;

public class QuickSortProblem
{
    public void Sort(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
    }
    
    private void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;
        
        var pivot = Partition(arr, left, right);
        QuickSort(arr, left, pivot - 1);
        QuickSort(arr, pivot + 1, right);
    }

    private int Partition(int[] arr, int left, int right)
    {
        var pivot = arr[right];
        var i = left - 1;
        var j = left;

        while (j < right)
        {
            if (arr[j] < pivot)
            {
                i += 1;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            j++;
        }

        i += 1;
        (arr[i], arr[j]) = (arr[j], arr[i]);
        
        return i;
    }
}