using Leetcode.Algorithm;

var service = new IsBalanceTreeProblem();

var tree = new IsBalanceTreeProblem.TreeNode(0);
tree.left = new IsBalanceTreeProblem.TreeNode(1);
tree.right = new IsBalanceTreeProblem.TreeNode(2);
tree.left.left = new IsBalanceTreeProblem.TreeNode(3);
tree.left.left.left = new IsBalanceTreeProblem.TreeNode(4);


var result = service.IsBalanced(tree);

Console.WriteLine();