namespace Leetcode.Algorithm;

public class SubsetTwoProblem
{
    public IList<IList<int>> SubsetsWithDup(int[] nums) 
    {
        Array.Sort(nums);
        var path = new List<int>();
        var result = new List<IList<int>>();
        Backtrack(nums, 0, path, result);
        
        return result;
    }

    private void Backtrack(int[] nums, int index, List<int> path, List<IList<int>> result)
    {
        result.Add(new List<int>(path));

        for (var i = index; i < nums.Length; i++)
        {
            if(i > index && nums[i] == nums[i - 1])
                continue;
            
            path.Add(nums[i]);
            Backtrack(nums, i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}