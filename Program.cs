using Leetcode.Algorithm;

var service = new MaximumDepthOfTreeProblem();

var root = new MaximumDepthOfTreeProblem.TreeNode(3);
root.left = new MaximumDepthOfTreeProblem.TreeNode(9);
root.right = new MaximumDepthOfTreeProblem.TreeNode(20);
root.right.left = new MaximumDepthOfTreeProblem.TreeNode(15);
root.right.right = new MaximumDepthOfTreeProblem.TreeNode(7);

var result = service.MaxDepth(root);

Console.WriteLine();