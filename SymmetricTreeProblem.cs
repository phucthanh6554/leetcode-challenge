namespace Leetcode.Algorithm;

public class SymmetricTreeProblem
{
    public bool IsSymmetric(TreeNode root)
    {
        return CheckSymmetricIteratively(root);
        //return CheckSymmetricRecursive(root.left, root.right);
    }

    // Iterative solution
    private bool CheckSymmetricIteratively(TreeNode root)
    {
        var queue = new Queue<TreeNode?>();

        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        
        while (queue.Count > 1)
        {
            var node1 = queue.Dequeue();
            var node2 = queue.Dequeue();
            
            if(node1 == null && node2 == null)
                return true;
            
            if(node1 == null || node2 == null)
                return false;
            
            if(node1?.val != node2?.val)
                return false;
            
            queue.Enqueue(node1.left);
            queue.Enqueue(node2.right);
            queue.Enqueue(node1.right);
            queue.Enqueue(node2.left);
            
        }

        return true;
    }

    // recursive solution
    private bool CheckSymmetricRecursive(TreeNode? first, TreeNode? second)
    {
        if(first == null && second == null)
            return true;
        
        if(first == null || second == null)
            return false;
        
        if(first.val != second.val)
            return false;
        
        return CheckSymmetricRecursive(first.left, second.right) && CheckSymmetricRecursive(first.right, second.left);
    }
    
    public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}