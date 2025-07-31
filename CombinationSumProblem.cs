namespace Leetcode.Algorithm;

public class CombinationSumProblem
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        var result = new List<IList<int>>();
        var path = new List<int>();
        
        Backtrack(candidates, target, 0, 0, path, result);
        
        return result;
    }

    private void Backtrack(int[] candidates, int target, int index, int sum, List<int> path, IList<IList<int>> result)
    {
        if (sum == target)
        {
            result.Add(new List<int>(path));
            return;
        }

        if (sum > target)
            return;

        for (var i = index; i < candidates.Length; i++)
        {
            path.Add(candidates[i]);
            Backtrack(candidates, target, i, sum + candidates[i], path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}