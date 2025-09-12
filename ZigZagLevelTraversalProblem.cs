namespace Leetcode.Algorithm;

public class ZigZagLevelTraversalProblem
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root == null)
            return new List<IList<int>>(0);

        var result = new List<IList<int>>();

        var queue = new Queue<TreeNode>();

        var currentLevel = 1;

        queue.Enqueue(root);

        while(queue.Count > 0) {
            var currentList = new List<int>(queue.Count);

            var count = queue.Count;

            for(var i = 0; i < count; i++) {
                var node = queue.Dequeue();

                if(node == null)
                    continue;

                currentList.Add(node.val);

                if(node.left != null)
                    queue.Enqueue(node.left);

                if(node.right != null)
                    queue.Enqueue(node.right);
            }

            if(currentList.Count > 0)
            {
                if(currentLevel % 2 == 0)
                    currentList.Reverse();

                result.Add(currentList);
            }

            currentLevel++;
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