namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/count-unguarded-cells-in-the-grid/description/?envType=daily-question&envId=2025-11-02
/// </summary>
public class CountUnguardedCellProblem
{
    public enum Direction
    {
        left,
        right,
        up,
        down
    }
    
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) 
    {
        // 0 for valid cell, 1 for guard, 2 for wall, 3 for guarded area
        var matrix = new byte[m, n];
        
        foreach(var guard in guards)
            matrix[guard[0], guard[1]] = 1;
        
        foreach(var wall in walls)
            matrix[wall[0], wall[1]] = 2;

        foreach (var guard in guards)
        {
            SetGuardedArea(matrix, guard[0], guard[1] - 1, Direction.left);
            SetGuardedArea(matrix, guard[0], guard[1] + 1, Direction.right);
            SetGuardedArea(matrix, guard[0] - 1, guard[1], Direction.up);
            SetGuardedArea(matrix, guard[0] + 1, guard[1], Direction.down);
        }
        
        var result = 0;

        for (var i = 0; i < m; i++)
        {
            for(var j = 0; j < n; j++)
                result += matrix[i, j] == 0 ? 1 : 0;
        }
        
        return result;
    }

    private void SetGuardedArea(byte[,] matrix, int x, int y, Direction direction)
    {
        if(x < 0 || x >= matrix.GetLength(0) || y < 0 || y >= matrix.GetLength(1) || matrix[x, y] == 1 || matrix[x, y] == 2)
            return;
        
        matrix[x, y] = 3;

        switch (direction)
        {
            case Direction.left:
                SetGuardedArea(matrix, x, y - 1, direction);
                break;
            case Direction.right:
                SetGuardedArea(matrix, x, y + 1, direction);
                break;
            case Direction.up:
                SetGuardedArea(matrix, x - 1, y, direction);
                break;
            case Direction.down:
                SetGuardedArea(matrix, x + 1, y, direction);
                break;
        }
    }
}