using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new MergeIntervalsProblem();

var arr = new int[4][]
{
    new int[] { 1, 3 },
    new int[] { 2, 6 },
    new int[] { 8, 10 },
    new int[] { 15, 18 },
};

var result = service.Merge(arr);

Console.WriteLine();