namespace Leetcode.Algorithm;

public class BinaryInorderTraveralProblem
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var result = new List<int>();
        
        var curr = root;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            
            curr = stack.Pop();
            result.Add(curr.val);
            curr = curr.right;
        }
        
        return result;
    }

    
    // Recursive solution
    private void Traversal(TreeNode? root, List<int> list)
    {
        if(root == null)
            return;
        
        Traversal(root.left, list);
        list.Add(root.val);
        Traversal(root.right, list);
    }
    
public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

}