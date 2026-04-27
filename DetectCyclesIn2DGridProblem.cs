namespace Leetcode.Algorithm;

public struct Point
{
    public int X { get; set; }
    
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class DetectCyclesIn2DGridProblem
{
    private static int[][] _directions = new[]
    {
        new[] { 0, 1 },
        new[] { 1, 0 },
        new[] { 0, -1 },
        new[] { -1, 0 },
    };
    
    public bool ContainsCycle(char[][] grid) 
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var result = false;
        
        var visited = new bool[rows, cols];
        
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (!visited[row, col])
                {
                    result = Recursive(grid, row, col, -1, -1, visited);
                    
                    if(result)
                        return true;
                }
            }
        }
        
        return result;
    }

    private bool Recursive(char[][] grid, int x, int y, int px, int py, bool[,] visited)
    {
        visited[x, y] = true;

        foreach (var direction in _directions)
        {
            var newPx = x + direction[0];
            var newPy = y + direction[1];
            
            if(newPx < 0 || newPx >= grid.Length || newPy < 0 || newPy >= grid[0].Length)
                continue;
            
            if(grid[x][y] != grid[newPx][newPy])
                continue;
            
            if(newPx == px && newPy == py)
                continue;

            if (visited[newPx, newPy])
                return true;
            
            if(Recursive(grid, newPx, newPy, x, y, visited))
                return true;
        }
        
        return false;
    }
}