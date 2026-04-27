using Leetcode.Algorithm;

var service = new DetectCyclesIn2DGridProblem();

var grid = new char[][]
{
    ['a','a','a','a'],['a','b','b','a'],['a','b','b','a'],['a','a','a','a']
};

var test = service.ContainsCycle(grid);

Console.WriteLine(test);

// 1, 3, 1, 1, 2

// 5, 0, 3, 4, 0

// 1: 0, 2, 3

// Prefix sum: 0, 0, 2, 5

// x (a - x) + (b - x) => sum - nx

// 0 + 