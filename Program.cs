using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new MinimumPathSumProblem();

var grid = new int[3][]
{
    new[] { 1, 3, 1 },
    new[] { 1, 5, 1 },
    new[] { 4, 2, 1 },
};

var result = service.MinPathSum(grid);

Console.WriteLine();