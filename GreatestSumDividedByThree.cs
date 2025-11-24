namespace Leetcode.Algorithm;

public class GreatestSumDividedByThree
{
    public int MaxSumDivThree(int[] nums)
    {
        var dpArr = new int[] { 0, int.MinValue, int.MinValue };

        foreach (var num in nums)
        {
            var cloneDp = (int[]) dpArr.Clone();
            
            foreach (var dp in dpArr)
            {
                if(dp == int.MinValue)
                    continue;

                var sum = dp + num;
                var mod = sum % 3;
                cloneDp[mod] = Math.Max(cloneDp[mod], sum);
            }
            
            dpArr = cloneDp;
        }
        
        return dpArr[0];
    }
}