using Leetcode.Algorithm;

var service = new SameTreeProblem();

var root = new SameTreeProblem.TreeNode(1);
root.left = new SameTreeProblem.TreeNode(2);
//root.right = new SameTreeProblem.TreeNode(3);
//root.left.left = new SameTreeProblem.TreeNode(4);
//root.left.right = new SameTreeProblem.TreeNode(5);

var root2 = new SameTreeProblem.TreeNode(1);
root2.left = null;
root2.right = new SameTreeProblem.TreeNode(2);
//root2.left.left = new SameTreeProblem.TreeNode(4);
//root2.left.right = new SameTreeProblem.TreeNode(5);

var result = service.IsSameTree(root, root2);

Console.WriteLine();


// BinaryInorderTraveralProblem.TreeNode root = new BinaryInorderTraveralProblem.TreeNode(1);
// root.left = new BinaryInorderTraveralProblem.TreeNode(2);
// root.right = new BinaryInorderTraveralProblem.TreeNode(3);
// root.left.left = new BinaryInorderTraveralProblem.TreeNode(4);
// root.left.right = new BinaryInorderTraveralProblem.TreeNode(5);
// root.right.right = new BinaryInorderTraveralProblem.TreeNode(6);