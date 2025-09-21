using System.Buffers;

namespace Leetcode.Algorithm;

public class MergeSortProblem
{
    private int[] _tempArray;
    
    public void Sort(int[] nums)
    {
        _tempArray = ArrayPool<int>.Shared.Rent(nums.Length);
        MergeSort(nums, 0, nums.Length - 1);
        
        ArrayPool<int>.Shared.Return(_tempArray);
    }

    private void MergeSort(int[] nums, int left, int right)
    {
        if (left == right)
            return;
        
        var mid = (left + right) / 2;
        
        MergeSort(nums, left, mid);
        MergeSort(nums, mid + 1, right);
        
        Merge(nums, left, mid, right);
    }

    private void Merge(int[] nums, int left, int mid, int right)
    {
        // 0 1 2 3
        var i = left;
        var j = mid + 1;
        var k = left;

        while (i <= mid && j <= right)
        {
            if(nums[i] < nums[j])
                _tempArray[k] = nums[i++];
            else
                _tempArray[k] = nums[j++];
            k++;
        }
        
        while(i <= mid)
            _tempArray[k++] = nums[i++];
        
        while(j <= right)
            _tempArray[k++] = nums[j++];

        for (var z = left; z <= right; z++)
            nums[z] = _tempArray[z];
    }
}