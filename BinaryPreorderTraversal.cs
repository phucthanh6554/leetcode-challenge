namespace Leetcode.Algorithm;

public class BinaryPreorderTraversal
{
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        return TraverseIterative(root);
    }

    private void TraverseRecursive(TreeNode? root, List<int> result)
    {
        if (root == null)
            return;
        
        result.Add(root.val);
        TraverseRecursive(root.left, result);
        TraverseRecursive(root.right, result);
    }

    private IList<int> TraverseIterative(TreeNode? root)
    {
        if (root == null)
            return new List<int>();
        
        var result = new List<int>();
        
        var stack = new Stack<TreeNode?>();
        
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            
            if(node == null)
                continue;
            
            result.Add(node.val);
            
            stack.Push(node.right);
            stack.Push(node.left);
        }
        
        return result;
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