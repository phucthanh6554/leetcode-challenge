using Leetcode.Algorithm;

var service = new PathSumProblem();

var root = new PathSumProblem.TreeNode(1)
{
    left = new PathSumProblem.TreeNode(-2)
    {
        left = new PathSumProblem.TreeNode(1)
        {
            left = new PathSumProblem.TreeNode(-1)
        },
        right = new PathSumProblem.TreeNode(3)
    },
    right = new PathSumProblem.TreeNode(-3)
    {
        left = new PathSumProblem.TreeNode(-2)
    }
};

var result = service.HasPathSum(root, -1);

Console.WriteLine();