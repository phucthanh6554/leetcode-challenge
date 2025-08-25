using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new WordSearchProblem();

var board = new char[][]
{
    new[] { 'A', 'B', 'C', 'E' },
    new[] { 'S', 'F', 'C', 'S' },
    new[] { 'A', 'D', 'E', 'E' }
};

service.Exist(board, "ABCCED");

Console.WriteLine();