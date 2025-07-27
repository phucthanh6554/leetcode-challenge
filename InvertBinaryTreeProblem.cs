namespace Leetcode.Algorithm;

public class InvertBinaryTreeProblem
{
    public TreeNode InvertTree(TreeNode root) 
    {
        var curr = root;
        var queue = new Queue<TreeNode?>();
        
        queue.Enqueue(curr);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            
            if(node == null)
                continue;
            
            (node.left, node.right) = (node.right, node.left);

            if (node.left != null)
                queue.Enqueue(node.left);
            
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return curr;
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