namespace Leetcode.Algorithm;

public class MaximumDepthOfTreeProblem
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepthRecursive(root);
    }

    private int MaxDepthRecursive(TreeNode? root)
    {
        if(root == null)
            return 0;
        
        return 1 + Math.Max(MaxDepthRecursive(root.left), MaxDepthRecursive(root.right));
    }

    private int MaxDepthStack(TreeNode root)
    {
        // Store node and depth of that node
        var stack = new Stack<(TreeNode?, int)>();
        
        stack.Push((root, 1));
        var maxDepth = 0;

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();

            if (node != null)
            {
                maxDepth = Math.Max(maxDepth, depth);
                
                if(node.left != null)
                    stack.Push((node.left, depth + 1));
                
                if (node.right != null)
                    stack.Push((node.right, depth + 1));
            }
        }
        
        return maxDepth;
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