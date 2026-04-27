namespace Leetcode.Algorithm;

public class SumOfDistancesProblem
{
    public long[] Distance(int[] nums)
    {
        var result = new long[nums.Length];
        
        var dictionary = new Dictionary<int, List<long>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if(!dictionary.ContainsKey(nums[i]))
                dictionary[nums[i]] = new List<long>();
            
            dictionary[nums[i]].Add(i);
        }

        foreach (var kvp in dictionary)
        {
            var prefixSum = new long[kvp.Value.Count + 1];

            for (var i = 0; i < kvp.Value.Count; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + kvp.Value[i];
            }

            for (var i = 0; i < kvp.Value.Count; i++)
            {
                var leftSum = i * kvp.Value[i] - prefixSum[i];
                var rightSum = (prefixSum[kvp.Value.Count] - prefixSum[i + 1]) - ((kvp.Value.Count - i - 1) * kvp.Value[i]);

                var sum = leftSum + rightSum;
                
                result[kvp.Value[i]] = sum;
            }
        }
        
        return result;
    }
}