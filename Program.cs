using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new BinaryTreePathProblem();

var tree = new BinaryTreePathProblem.TreeNode(1);
tree.left = new BinaryTreePathProblem.TreeNode(2);
tree.left.right = new BinaryTreePathProblem.TreeNode(5);
tree.right = new BinaryTreePathProblem.TreeNode(3);

var result = service.BinaryTreePaths(tree);

Console.WriteLine();