using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new CountUnguardedCellProblem();

var guards = new int[][]
{
    new[] { 1, 1 }
};

var walls = new int[][]
{
    new[] { 0, 1 },
    new[] { 1, 0 },
    new[] { 2, 1 },
    new[] { 1, 2 },
};

var max = service.CountUnguarded(3, 3, guards, walls);


Console.WriteLine();