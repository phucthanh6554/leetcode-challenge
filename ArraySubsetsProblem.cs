namespace Leetcode.Algorithm;

public class ArraySubsetsProblem
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var path = new List<int>();
        var result = new List<IList<int>>();
        
        result.Add(new List<int>(0));

        for (var i = 1; i <= nums.Length; i++)
        {
            Backtrack(nums, 0, i, path, result);
        }
        
        return result;
    }

    private void Backtrack(int[] nums, int index, int expectedSubsetCount, List<int> path, List<IList<int>> result)
    {
        if(index > nums.Length)
            return;

        if (path.Count > 0 && path.Count == expectedSubsetCount)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int j = index; j < nums.Length; j++)
        {
            path.Add(nums[j]);
            Backtrack(nums, j + 1, expectedSubsetCount, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}