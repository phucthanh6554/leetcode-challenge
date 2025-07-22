using Leetcode.Algorithm;

var service = new BinaryPostorderTraversal();

var tree = new BinaryPostorderTraversal.TreeNode(1);
tree.right = new BinaryPostorderTraversal.TreeNode(2);
tree.right.left = new BinaryPostorderTraversal.TreeNode(3);

var result = service.PostorderTraversal(tree);

Console.WriteLine();