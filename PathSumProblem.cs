namespace Leetcode.Algorithm;

public class PathSumProblem
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root == null)
            return false;
        
        var queue = new Queue<(TreeNode? node, int sum)>();
        
        queue.Enqueue((root, root.val));

        while (queue.Count > 0)
        {
            var (node, sum) = queue.Dequeue();
            
            if(node == null)
                continue;
            
            if(sum == targetSum && node.left == null && node.right == null)
                return true;
            
            if(node.left != null)
                queue.Enqueue((node.left, sum + node.left.val));
            
            if(node.right != null)
                queue.Enqueue((node.right, sum + node.right.val));
        }
        
        return false;
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