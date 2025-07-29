namespace Leetcode.Algorithm;

public class SummaryRangesProblem
{
    public IList<string> SummaryRanges(int[] nums) 
    {
        var result = new List<string>();

        int i;
        var j = 0;

        for (i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] + 1 != nums[i + 1])
            {
                if(i == j)
                    result.Add(nums[i].ToString());
                else
                    result.Add($"{nums[j]}->{nums[i]}");

                j = i + 1;
            }
        }
        
        if(j < i)
            result.Add($"{nums[j]}->{nums[i]}");
        else if (j == i)
            result.Add(nums[i].ToString());
        
        return result;
    }
}