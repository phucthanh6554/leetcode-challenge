namespace Leetcode.Algorithm;

public class ConvertSortedListToBstProblem
{
    public TreeNode SortedListToBST(ListNode head) {
        if(head == null) 
            return null;

        var result = BuildWithoutArray(head);

        return result;
    }

    private TreeNode BuildWithoutArray(ListNode? head)
    {
        if(head == null)
            return null;
        
        if(head.next == null)
            return new TreeNode(head.val);
        
        var slow = head;
        var fast = head;

        ListNode? prev = null;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
    
        if(prev != null)
            prev.next = null;
        
        var node = new TreeNode(slow.val);
        node.left = BuildWithoutArray(head);
        node.right = BuildWithoutArray(slow.next);

        return node;
    }

    private TreeNode BuildWithArray(TreeNode? tree, List<int> arr, int left, int right)
    {
        var mid = (left + right) / 2;
        var node = new TreeNode(arr[mid]);
        
        if(tree == null)
            return node;

        node.left = BuildWithArray(tree.left, arr, left, mid - 1);
        node.right = BuildWithArray(tree.right, arr, mid + 1, right);
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