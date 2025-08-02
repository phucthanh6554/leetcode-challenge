using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new RotateImageProblem();

var matrix = new int[][]
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5, 6 },
    new int[] { 7, 8, 9 },
};

service.Rotate(matrix);

Console.WriteLine();