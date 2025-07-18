namespace Leetcode.Algorithm;

public class ConvertSortedArrayToBinarySearchTreeProblem
{
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        if(nums.Length == 0)
            return null;
        
        return CreateTree(nums, 0, nums.Length - 1);
    }

    private TreeNode? CreateTree(int[] nums, int left, int right)
    {
        if(left > right)
            return null;
        
        var mid = (left + right) / 2;
        var num = nums[mid];
        
        var node = new TreeNode(num);
        
        node.left = CreateTree(nums, left, mid - 1);
        node.right = CreateTree(nums, mid + 1, right);
        return node;
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