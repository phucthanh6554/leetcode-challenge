namespace Leetcode.Algorithm;

public class CombinationTwoProblem
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
    {
        Array.Sort(candidates);
        
        var result = new List<IList<int>>();
        Backtrack(candidates, target, 0, 0, new List<int>(), result);
        
        return result;
    }

    private void Backtrack(int[] candidates, int target, int index, int sum, List<int> path, List<IList<int>> result)
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
            if(i > index && candidates[i] == candidates[i - 1])
                continue;
            
            path.Add(candidates[i]);
            Backtrack(candidates, target, i + 1, sum + candidates[i], path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}