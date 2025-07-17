using Leetcode.Algorithm;

var service = new SymmetricTreeProblem();

var root = new SymmetricTreeProblem.TreeNode(1);
root.left = new SymmetricTreeProblem.TreeNode(2);
root.right = new SymmetricTreeProblem.TreeNode(2);

root.left.left = new SymmetricTreeProblem.TreeNode(3);
root.left.right = new SymmetricTreeProblem.TreeNode(4);

root.right.left = new SymmetricTreeProblem.TreeNode(4);
//root.right.right = new SymmetricTreeProblem.TreeNode(3);

var result = service.IsSymmetric(root);

Console.WriteLine();