namespace Leetcode.Algorithm;

public class SameTreeProblem
{
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var queue1 = new Queue<TreeNode?>();
        var queue2 = new Queue<TreeNode?>();

        queue1.Enqueue(p);
        queue2.Enqueue(q);
        
        while (queue1.Count > 0 || queue2.Count > 0)
        {
            var node1 = queue1.Count > 0 ? queue1.Dequeue() : null;
            var node2 = queue2.Count > 0 ? queue2.Dequeue() : null;
            
            if(node1?.val != node2?.val)
                return false;
            
            if (node1 != null)
            {
                queue1.Enqueue(node1.left);
                queue1.Enqueue(node1.right);
            }
            
            if (node2 != null)
            {
                queue2.Enqueue(node2.left);
                queue2.Enqueue(node2.right);
            }
        }
        
        return true;
    }

    public List<int> Tranversal(TreeNode root)
    {
        var result = new List<int>();
        
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node != null)
            {
                result.Add(node.val);
                
                if(node.left != null)
                    queue.Enqueue(node.left);
                
                if(node.right != null)
                    queue.Enqueue(node.right);
            }
        }
        
        return result;
    }

    public void Recursive(TreeNode? root, List<int> result)
    {
        if(root == null)
            return;
        
        result.Add(root.val);
        Recursive(root.left, result);
        Recursive(root.right, result);
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