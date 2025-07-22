namespace Leetcode.Algorithm;

public class BinaryPostorderTraversal
{
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        return TraverseIterative(root);
    }

    private void TraverseRecursive(TreeNode? root, List<int> result)
    {
        if(root == null)
            return;
        
        TraverseRecursive(root.left, result);
        TraverseRecursive(root.right, result);
        result.Add(root.val);
    }

    private IList<int> TraverseIterative(TreeNode? root)
    {
        var result = new List<int>();
        
        var stack = new Stack<TreeNode?>();
        
        var curr = root;

        TreeNode? lastVisited = null;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }

            var peek = stack.Peek();
            
            if(peek == null)
                continue;

            if (peek.right != null && peek.right != lastVisited)
            {
                curr = peek.right;
            }
            else
            {
                result.Add(peek.val);
                lastVisited = stack.Pop();
            }
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