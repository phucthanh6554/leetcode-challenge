
using Leetcode.Algorithm;

var tree = new BinaryTreePlayground.TreeNode(1);
tree.left = new BinaryTreePlayground.TreeNode(2);
tree.right = new BinaryTreePlayground.TreeNode(3);
tree.left.left = new BinaryTreePlayground.TreeNode(4);
tree.left.right = new BinaryTreePlayground.TreeNode(5);
tree.right.left = new BinaryTreePlayground.TreeNode(6);
tree.right.right = new BinaryTreePlayground.TreeNode(7);
tree.right.right.right = new BinaryTreePlayground.TreeNode(8);

var service = new BinaryTreePlayground();

var arr = new int[] { 4, 5, 2, 3 };

var a = new int[][]
{
    new int[] { 1, 3 },
    new int[] { 2, 4 },
    new int[] { 3, 5 },
};

var target = 9;

var dic = new Dictionary<int, int>();

dic.Add(arr[0], 0);

for (var i = 1; i < arr.Length; i++)
{
    var remaining = target - arr[i];

    if (dic.ContainsKey(remaining))
    {
        Console.WriteLine(i + " - " + dic[remaining]);
        break;
    }
    
    dic.Add(arr[i], i);
}

Console.WriteLine();