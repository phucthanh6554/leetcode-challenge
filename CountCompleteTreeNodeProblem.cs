namespace Leetcode.Algorithm;

public class CountCompleteTreeNodeProblem
{
    public int CountNodes(TreeNode root)
    {
        var leftNode = root;
        var leftDepth = 1;

        while (leftNode.left != null && leftNode.right != null)
        {
            leftNode = leftNode.left;
            leftDepth++;
        }

        if (leftNode.left != null)
            leftDepth += 1;
        
        var rightNode = root;
        var rightDepth = 1;

        while (rightNode.right != null && rightNode.left != null)
        {
            rightNode = rightNode.right;
            rightDepth++;
        }

        var fullTotalNodes =(int) Math.Pow(2, leftDepth) - 1;

        if (leftNode.left != null && leftNode.right == null)
            fullTotalNodes -= 1;
        
        if(rightNode.left != null && rightNode.right == null)
            fullTotalNodes -= 1;
        else if (leftDepth > rightDepth)
            fullTotalNodes -= 2;
        
        return fullTotalNodes;
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}