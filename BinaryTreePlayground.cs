namespace Leetcode.Algorithm;

public class BinaryTreePlayground
{
    public void InorderTraversalRecursive(TreeNode node)
    {
        if (node == null)
            return;
        
        InorderTraversalRecursive(node.left);
        Console.Write(node.val + " ");
        InorderTraversalRecursive(node.right);
    }
    
    public void InorderTraversalIterative(TreeNode? node)
    {
        if (node == null)
            return;
        
        var current = node;
        var stack = new Stack<TreeNode?>();

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            
            current = stack.Pop();
            
            if(current == null)
                continue;
            
            Console.Write(current.val + " ");
            current = current.right;
        }
    }

    public void PreorderTraversalRecursive(TreeNode? node)
    {
        if(node == null)
            return;
        
        Console.Write(node.val + " ");
        PreorderTraversalRecursive(node.left);
        PreorderTraversalRecursive(node.right);
    }

    public void PreorderTraversalIterative(TreeNode? node)
    {
        if(node == null)
            return;
        
        var stack = new Stack<TreeNode?>();
        stack.Push(node);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            
            if(current == null)
                continue;
            
            Console.Write(current.val + " ");
            stack.Push(current.right);
            stack.Push(current.left);
        }
    }

    public void PostorderTraversalRecursive(TreeNode? node)
    {
        if(node == null)
            return;
        
        PostorderTraversalRecursive(node.left);
        PostorderTraversalRecursive(node.right);
        Console.Write(node.val + " ");
    }

    public void PostorderTraversalIterative(TreeNode? node)
    {
        if (node == null)
            return;

        var current = node;
        var stack = new Stack<TreeNode?>();

        TreeNode? lastVisited = null;

        while (current != null || stack.Count > 0)
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            else
            {
                var peek = stack.Peek();

                if (peek?.right != null && peek.right != lastVisited)
                {
                    current = peek.right;
                }
                else
                {
                    Console.Write(peek.val + " ");
                    lastVisited = stack.Pop();
                }
            }
        }
    }

    public int MaxDepthRecursive(TreeNode? node, int depth)
    {
        if(node == null)
            return depth - 1;
        
        return Math.Max(MaxDepthRecursive(node.left, depth + 1), MaxDepthRecursive(node.right, depth + 1));
    }

    public int MaxDepthIterative(TreeNode? node)
    {
        if (node == null)
            return 0;
        
        var queue = new Queue<TreeNode?>();
        
        queue.Enqueue(node);

        var depth = 0;
        while (queue.Count > 0)
        {
            var count = queue.Count;
            for (var i = 0; i < count; i++)
            {
                var current = queue.Dequeue();
                
                if(current.left != null)
                    queue.Enqueue(current.left);
                
                if(current.right != null)
                    queue.Enqueue(current.right);
            }
            
            depth++;
        }
        
        return depth;
    }

    public bool PathSumRecursive(TreeNode? node, int target)
    {
        bool Recursive(TreeNode? node, int target, int sum)
        {
            if (node == null)
                return false;
            
            if(node.left == null && node.right == null && sum + node.val == target)
                return true;
            
            return Recursive(node.left, target, sum + node.val) || Recursive(node.right, target, sum + node.val);
        }

        return Recursive(node, target, 0);
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