namespace Leetcode.Algorithm;

public class PermutationProblem
{
    public IList<IList<int>> Permute(int[] nums) 
    {
        var result = new List<IList<int>>();
        
        Span<bool> visited = stackalloc bool[nums.Length];
        
        BackTrack(nums, visited, new List<int>(), result);
        return result;
    }

    private void BackTrack(int[] nums, Span<bool> visited, List<int> path, List<IList<int>> result)
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
            
            path.Add(nums[i]);
            visited[i] = true;
            BackTrack(nums, visited, path, result);
            path.RemoveAt(path.Count - 1);
            visited[i] = false;
        }
    }
}