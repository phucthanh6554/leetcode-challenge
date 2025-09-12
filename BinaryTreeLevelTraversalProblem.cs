namespace Leetcode.Algorithm;

public class BinaryTreeLevelTraversalProblem
{
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null)
            return new List<IList<int>>();
        
        var queue = new Queue<(TreeNode node, int level)>();

        var result = new List<IList<int>>();

        queue.Enqueue((root, 1));

        var currentLevel = 1;

        var list = new List<int>();

        while(queue.Count > 0) {
            var item = queue.Dequeue();

            if(item.level > currentLevel) {
                currentLevel = item.level;
                result.Add(new List<int>(list));
                list.Clear();
            }

            list.Add(item.node.val);

            if(item.node.left != null)
                queue.Enqueue((item.node.left, item.level + 1));

            if(item.node.right != null)
                queue.Enqueue((item.node.right, item.level + 1));
        }

        if(list.Count > 0)
            result.Add(new List<int>(list));

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