using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new MinimumTimeToMakeRopeColorful();

var max = service.MinCost("aabaa", new[] { 1, 2, 3, 4, 1 });


Console.WriteLine();