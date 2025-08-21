namespace Leetcode.Algorithm;

public class SortColorProblem
{
    public void SortColors(int[] nums)
    {
        MyMethodToSort(nums);
    }

    // My stupid method
    private static void MyMethodToSort(int[] nums)
    {
        var zeroCount = 0;
        var oneCount = 0;
        var twoCount = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                zeroCount++;
            else if(nums[i] == 1)
                oneCount++;
            else
                twoCount++;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (zeroCount > 0)
            {
                nums[i] = 0;
                zeroCount--;
            }
            else if (oneCount > 0)
            {
                nums[i] = 1;
                oneCount--;
            }
            else
            {
                nums[i] = 2;
                twoCount--;
            }
        }
    }
}