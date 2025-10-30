using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new MinimumNumberOfIncrementToFormTarget();

var max = service.MinNumberOperations(new[] { 3,1,5,4,2 });


Console.WriteLine();