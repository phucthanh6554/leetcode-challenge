namespace Leetcode.Algorithm;

public class PermutationUniqueProblem
{
    public IList<IList<int>> PermuteUnique(int[] nums) 
    {
        Span<bool> visited = stackalloc bool[nums.Length];
        var result = new List<IList<int>>();
        
        Array.Sort(nums);
        
        Backtrack(nums, visited, new List<int>(), result);
        
        return result;
    }

    private void Backtrack(int[] nums, Span<bool> visited, List<int> path, List<IList<int>> result)
    {
        if (path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if(visited[i])
                continue;
            
            if(i > 0 && nums[i] == nums[i - 1] && !visited[i - 1])
                continue;
            
            path.Add(nums[i]);
            visited[i] = true;
            Backtrack(nums, visited, path, result);
            path.RemoveAt(path.Count - 1);
            visited[i] = false;
        }
    }
}