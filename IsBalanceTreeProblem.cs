namespace Leetcode.Algorithm;

public class IsBalanceTreeProblem
{
    public bool IsBalanced(TreeNode root)
    {
        return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode? root)
    {
        if (root == null)
            return 0;
        
        var left = GetHeight(root.left);

        if (left == -1)
            return -1;
        
        var right = GetHeight(root.right);
        if(right == -1)
            return -1;

        if (Math.Abs(left - right) > 1)
            return -1;
        
        return 1 + Math.Max(left, right);
    }

    private int MaxDepthRight(TreeNode? node)
    {
        var depth = 0;

        while (node != null)
        {
            depth += 1;
            node = node.right;
        }
        
        return depth;
    }
    
    private int MaxDepthLeft(TreeNode? node)
    {
        var depth = 0;

        while (node != null)
        {
            depth += 1;
            node = node.left;
        }
        
        return depth;
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