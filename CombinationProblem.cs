namespace Leetcode.Algorithm;

public class CombinationProblem
{
    public IList<IList<int>> Combine(int n, int k) 
    {
        var result = new List<IList<int>>();
        
        var max = n - k + 1;

        for (var i = 1; i <= max; i++)
        {
            result.Add(new List<int>{i});
        }

        var count = 1;

        for (var i = 1; i < k; i++)
        {
            var temp = new List<IList<int>>();

            foreach (var item in result)
            {
                for (var j = item[^1] + 1; j <= n; j++)
                {
                    item.Add(j);
                    temp.Add(new List<int>(item));
                    item.RemoveAt(item.Count - 1);
                }
            }

            result = temp;
        }
        
        return result;
    }

    private void Backtrack(int n, int k, Span<bool> visited, List<int> path, List<IList<int>> result)
    {
        if (path.Count == k)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (var i = 1; i <= n; i++)
        {
            if(visited[i - 1])
                continue;
            
            if(path.Count > 0 && path[^1] > i)
                continue;
            
            path.Add(i);
            visited[i - 1] = true;
            Backtrack(n, k, visited, path, result);
            path.RemoveAt(path.Count - 1);
            visited[i - 1] = false;
        }
    }
}