namespace Leetcode.Algorithm;

public class ThreeSumProblem
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    while(left < right && nums[left] == nums[left+1])
                        left++;
                    
                    while(right > left && nums[right] == nums[right-1])
                        right--;
                    
                    left++;
                    right--;
                }
                else
                {
                    if(sum < 0)
                        left++;
                    else
                        right--;
                }
            }
        }
        
        return result;
    }
}