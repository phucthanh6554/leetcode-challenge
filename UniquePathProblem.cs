namespace Leetcode.Algorithm;

public class UniquePathProblem
{
    public int UniquePaths(int m, int n)
    {
        var result = new int[m,n];
        
        for(int i = 0; i < m; i++)
            result[i, 0] = 1;
        
        for(int i = 0; i < n; i++)
            result[0, i] = 1;

        for (int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
                result[i, j] = result[i - 1, j] + result[i, j - 1];
        }
        
        return result[m - 1, n - 1];
    }

    // Backtrack solution => failed 
    private void Backtrack(int m, int n, Position nextPosition, List<Position> path, ref int result)
    {
        if(nextPosition.X == m || nextPosition.Y == n)
            return;

        if (nextPosition.X == m - 1 && nextPosition.Y == n - 1)
        {
            path.Add(nextPosition);
            result++;
            path.RemoveAt(path.Count - 1);
            return;
        }
        
        path.Add(nextPosition);

        var goDown = nextPosition with { X = nextPosition.X + 1 };
        Backtrack(m, n, goDown, path, ref result);
        
        var goRight = nextPosition with { Y = nextPosition.Y + 1 };
        Backtrack(m, n, goRight, path, ref result);
        
        path.RemoveAt(path.Count - 1);
    }

    public struct Position
    {
        public int X;
        
        public int Y;
    }
}