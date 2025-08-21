using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new SearchMatrixProblem();

var arr = new int[][]
{
    new int[] { 1, 3, 5, 7 },
    new int[] { 10, 11, 16, 20},
    new int[] { 23, 34, 40, 60 },
};

service.SearchMatrix(arr, 3);

Console.WriteLine();