using Leetcode.Algorithm;

var service = new CheckValidPathInGridProblem();

var grid = new int[][]
{
    [1]
};

var test = service.HasValidPath(grid);

Console.WriteLine(test);

// 1, 3, 1, 1, 2

// 5, 0, 3, 4, 0

// 1: 0, 2, 3

// Prefix sum: 0, 0, 2, 5

// x (a - x) + (b - x) => sum - nx

// 0 + 