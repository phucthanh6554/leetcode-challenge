using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new InsertIntervalProblem();

var arr = new int[1][]
{
    new [] {1, 5}
};

var newInterval = new int[] { 2, 3 };

var result = service.Insert(arr, newInterval);

Console.WriteLine();