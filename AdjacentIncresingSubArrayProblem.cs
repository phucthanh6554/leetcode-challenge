namespace Leetcode.Algorithm
{
    public class AdjacentIncresingSubArrayProblem
    {
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            if (nums.Count < k * 2)
                return false;

            var previousLength = 0;
            var current = 1;

            for (var i = 1; i < nums.Count; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    current++;

                    if (current >= k + k)
                        return true;
                }
                else
                {
                    if (previousLength >= k && current >= k)
                        return true;

                    previousLength = current;
                    current = 1;
                }
            }

            if (previousLength >= k && current >= k)
                return true;

            if(current >= k + k)
                return true;

            return false;
        }
    }
}
