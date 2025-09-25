namespace Leetcode.Algorithm;

public class NumberOfIslandsProblem
{
    public int NumIslands(char[][] grid) {
        var result = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    result++;
                    MarkIsland(grid, i, j);
                }
            }
        }
        
        return result;
    }

    public void MarkIsland(char[][] grid, int x, int y)
    {
        if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] == '0')
            return;
        
        grid[y][x] = '0';
        
        MarkIsland(grid, x + 1, y);
        MarkIsland(grid, x - 1, y);
        MarkIsland(grid, x, y + 1);
        MarkIsland(grid, x, y - 1);
    }
}