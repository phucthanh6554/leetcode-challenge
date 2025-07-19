namespace Leetcode.Algorithm;

public class MinimumDepthOfTreeProblem
{
    public int MinDepth(TreeNode root) 
    {
        if (root == null)
            return 0;
        
        var queue = new Queue<(TreeNode? node, int depth)>();
        
        queue.Enqueue((root, 1));
        
        var minDepth = int.MaxValue;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            
            if(node.node == null)
                continue;

            if (node.node.left == null && node.node.right == null)
                return node.depth;
            
            queue.Enqueue((node.node.left, node.depth + 1));
            queue.Enqueue((node.node.right, node.depth + 1));
        }
        
        return minDepth;
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