namespace Leetcode.Algorithm;

public class MergeSortedArrayProblem
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
                nums1[k--] = nums1[i--];
            else
                nums1[k--] = nums2[j--];
        }    
    }
    
    // public void Merge(int[] nums1, int m, int[] nums2, int n)
    // {
    //     var resultArr = new int[m + n];
    //
    //     var index = 0;
    //     var i = 0;
    //     var j = 0;
    //
    //     while (i < m || j < n)
    //     {
    //         if (i >= m)
    //             resultArr[index++] = nums2[j++];
    //         else if (j >= n)
    //             resultArr[index++] = nums1[i++];
    //         else
    //             resultArr[index++] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
    //     }
    //     
    //     for(var k = 0; k < resultArr.Length; k++)
    //         nums1[k] = resultArr[k];
    // }
}