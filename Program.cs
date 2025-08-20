using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new SetMatrixZerosProblem();

var arr = new int[][]
{
    new int[] { 0,1,2,0 },
    new int[] { 3,4,5,2 },
    new int[] { 1,3,1,5 },
};

service.SetZeroes(arr);

Console.WriteLine();