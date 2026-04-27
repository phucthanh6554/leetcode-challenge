namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/check-if-there-is-a-valid-path-in-a-grid/description/?envType=daily-question&envId=2026-04-26
/// </summary>
public class CheckValidPathInGridProblem
{
    private static readonly Dictionary<Direction, int[]> Directions = new Dictionary<Direction, int[]>
    {
        [Direction.Up] = [-1, 0],
        [Direction.Right] = [0, 1],
        [Direction.Down] = [1, 0],
        [Direction.Left] = [0, -1],
    };

    private static readonly Dictionary<int, Face> StreetFaces = new Dictionary<int, Face>
    {
        [1] = new Face(true, true, false, false),
        [2] = new Face(false, false, true, true),
        [3] = new Face(true, false, false, true),
        [4] = new Face(false, true, false, true),
        [5] = new Face(true, false, true, false),
        [6] = new Face(false, true, true, false),
    };
    
    public bool HasValidPath(int[][] grid) 
    {
        if(grid.Length == 1 && grid[0].Length == 1)
            return true;
        
        var visited = new bool[grid.Length, grid[0].Length];

        Recursive(grid, Direction.Down, 0, 0, visited);
        Recursive(grid, Direction.Right, 0, 0, visited);
        
        return visited[grid.Length - 1, grid[0].Length - 1];
    }

    private void Recursive(int[][] grid, Direction direction, int px, int py, bool[,] visited)
    {
        var x = px + Directions[direction][0];
        var y = py + Directions[direction][1];
        
        if(x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) 
            return;
        
        if(visited[x, y])
            return;
        
        if(!CanConnect(grid[px][py], grid[x][y], direction))
            return;
        
        visited[x, y] = true;

        Recursive(grid, Direction.Up, x, y, visited);
        Recursive(grid, Direction.Down, x, y, visited);
        Recursive(grid, Direction.Left, x, y, visited);
        Recursive(grid, Direction.Right, x, y, visited);
    }

    private bool CanConnect(int source, int destination, Direction direction)
    {
        var canConnect = false;
        
        var sourceStreet = StreetFaces[source];
        var destinationStreet = StreetFaces[destination];

        if (direction == Direction.Up)
            canConnect = sourceStreet.Up && destinationStreet.Down;
        else if (direction == Direction.Down)
            canConnect = sourceStreet.Down && destinationStreet.Up;
        else if(direction == Direction.Left)
            canConnect = sourceStreet.Left && destinationStreet.Right;
        else if (direction == Direction.Right)
            canConnect = sourceStreet.Right && destinationStreet.Left;
        
        return canConnect;
    }
}

public record Face(bool Left, bool Right, bool Up, bool Down);

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}