namespace Leetcode.Algorithm;

public class MajorityElementProblem
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = int.MinValue;

        foreach (var num in nums)
        {
            if(count == 0)
                candidate = num;

            if (num == candidate)
                count++;
            else
                count--;
        }
        
        return candidate;
    }
}