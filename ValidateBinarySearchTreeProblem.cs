namespace Leetcode.Algorithm;

public class ValidateBinarySearchTreeProblem
{
    public bool IsValidBST(TreeNode root) {
        return Recursive(root, int.MinValue, int.MaxValue);
    }

    private bool Recursive(TreeNode? node, int min, int max)
    {
        if (node == null)
            return true;
        
        if(node.val <= min && node.val >= max)
            return false;
        
        return Recursive(node.left, min, node.val) && Recursive(node.right, node.val, max);
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