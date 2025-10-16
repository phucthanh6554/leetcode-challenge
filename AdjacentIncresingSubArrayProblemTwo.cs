namespace Leetcode.Algorithm
{
    public class AdjacentIncresingSubArrayProblemTwo
    {
        public int MaxIncreasingSubarrays(IList<int> nums)
        {
            var previous = 0;
            var current = 1;

            var max = 0;

            for (var i = 1; i < nums.Count; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    current++;

                    max = Math.Max(max, current / 2);
                }
                else
                {
                    max = Math.Max(max, Math.Min(previous, current));

                    previous = current;
                    current = 1;
                }
            }

            if(max < previous || max < current)
                max = Math.Max(max, Math.Min(previous, current));

            return max;
        }
    }
}
