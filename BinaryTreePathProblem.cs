namespace Leetcode.Algorithm;

public class BinaryTreePathProblem
{
    public IList<string> BinaryTreePaths(TreeNode root) 
    {
        var paths = new List<int>();
        var result = new List<string>();
        Backtrack(root, paths, result);
        return result;
    }

    private void Backtrack(TreeNode? node, List<int> path, List<string> result)
    {
        if (node == null)
            return;
        
        path.Add(node.val);
        
        if (node != null && node.left == null && node.right == null)
        {
            var str = string.Join("->", path);
            result.Add(str);
            path.RemoveAt(path.Count - 1);
            return;
        }
        
        Backtrack(node.left, path, result);
        
        Backtrack(node.right, path, result);
        
        path.RemoveAt(path.Count - 1);
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