using Leetcode.Algorithm;

var service = new InvertBinaryTreeProblem();

var tree = new InvertBinaryTreeProblem.TreeNode(1);
tree.left = new InvertBinaryTreeProblem.TreeNode(2);
tree.right = new InvertBinaryTreeProblem.TreeNode(3);
tree.left.left = new InvertBinaryTreeProblem.TreeNode(4);
tree.left.right = new InvertBinaryTreeProblem.TreeNode(5);
tree.right.left = new InvertBinaryTreeProblem.TreeNode(6);
tree.right.right = new InvertBinaryTreeProblem.TreeNode(7);

var result = service.InvertTree(tree);
    
Console.WriteLine();