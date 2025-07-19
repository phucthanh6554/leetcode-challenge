using Leetcode.Algorithm;

var service = new MinimumDepthOfTreeProblem();

var tree = new MinimumDepthOfTreeProblem.TreeNode(3);
tree.left = new MinimumDepthOfTreeProblem.TreeNode(9);
tree.right = new MinimumDepthOfTreeProblem.TreeNode(20);
tree.right.left = new MinimumDepthOfTreeProblem.TreeNode(15);
tree.right.right = new MinimumDepthOfTreeProblem.TreeNode(7);


var result = service.MinDepth(tree);

Console.WriteLine();