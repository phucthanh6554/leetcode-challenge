using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new ValidateBinarySearchTreeProblem();

var tree = new ValidateBinarySearchTreeProblem.TreeNode(5);
tree.left = new ValidateBinarySearchTreeProblem.TreeNode(4);
tree.right = new ValidateBinarySearchTreeProblem.TreeNode(6);
tree.right.left = new ValidateBinarySearchTreeProblem.TreeNode(3);
tree.right.right = new ValidateBinarySearchTreeProblem.TreeNode(7);

var result = service.IsValidBST(tree);

Console.WriteLine();