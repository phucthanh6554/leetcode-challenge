using Leetcode.Algorithm;

var service = new RemoveNthNodeFromEndProblem();

var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

var result = service.RemoveNthFromEnd(new ListNode(1), 1);

Console.WriteLine(result);