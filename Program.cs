using Leetcode.Algorithm;

var service = new BinaryPreorderTraversal();

var tree = new BinaryPreorderTraversal.TreeNode(1);
tree.right = new BinaryPreorderTraversal.TreeNode(2);
tree.right.left = new BinaryPreorderTraversal.TreeNode(3);

var result = service.PreorderTraversal(tree);

Console.WriteLine();