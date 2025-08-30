namespace Leetcode.Algorithm;

public class TopKFrequentProblem
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dictionary = new Dictionary<int, int>();

        int max = int.MinValue;
        var stack = new Stack<(int num, int count)>();

        foreach (var num in nums)
        {
            if (!dictionary.TryAdd(num, 1))
            {
                dictionary[num] += 1;
            }
        }

        foreach (var key in dictionary.Keys)
        {
            if (stack.Count == 0)
            {
                stack.Push((key, dictionary[key]));
                continue;
            }
            
            var (num, count) = stack.Peek();

            if (count > dictionary[key])
            {
                var data = stack.Pop();
                stack.Push((key, dictionary[key]));
                stack.Push(data);
            }
            else
            {
                stack.Push((key, dictionary[key]));
            }
        }
        
        var result = new List<int>(k);

        for (var i = 0; i < k; i++)
        {
            result.Add(stack.Pop().num);
        }
        
        return result.ToArray();
    }
}