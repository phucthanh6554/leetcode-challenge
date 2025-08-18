namespace Leetcode.Algorithm;

public class MinimumPathSumProblem
{
    public int MinPathSum(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        
        var resultMap = new int[rows][];
        
        for(var i = 0; i < rows; i++)
            resultMap[i] = new int[cols];
        
        resultMap[0][0] = grid[0][0];
        
        // Rows setup
        for(var i = 1; i < rows; i++)
            resultMap[i][0] = grid[i][0] + resultMap[i - 1][0];
        
        // Columns setup
        for (var i = 1; i < cols; i++)
            resultMap[0][i] = grid[0][i] + resultMap[0][i - 1];

        for (var i = 1; i < rows; i++)
        {
            for (var j = 1; j < cols; j++)
            {
                var above = resultMap[i - 1][j];
                var left = resultMap[i][j - 1];
                
                var distance = Math.Min(grid[i][j] + above, grid[i][j] + left);
                resultMap[i][j] = distance;
            }
        }
        
        return resultMap[rows - 1][cols - 1];
    }
}