using Leetcode.Algorithm;

var service = new BinaryInorderTraveralProblem();

BinaryInorderTraveralProblem.TreeNode root = new BinaryInorderTraveralProblem.TreeNode(1);
root.left = new BinaryInorderTraveralProblem.TreeNode(2);
root.right = new BinaryInorderTraveralProblem.TreeNode(3);
root.left.left = new BinaryInorderTraveralProblem.TreeNode(4);
root.left.right = new BinaryInorderTraveralProblem.TreeNode(5);
root.right.right = new BinaryInorderTraveralProblem.TreeNode(6);

var result = service.InorderTraversal(root);

Console.WriteLine();
