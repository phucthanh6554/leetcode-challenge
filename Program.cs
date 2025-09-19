
using Leetcode.Algorithm;

var node = new ListNode(1, new ListNode(4, new ListNode(5)));
var node2 = new ListNode(1, new ListNode(3, new ListNode(4)));
var node3 = new ListNode(2, new ListNode(6));

var service = new MergeKListProblem();

ListNode a = null;
ListNode b = null;

var result = service.MergeKLists(new []{ node, node2, node3});

Console.WriteLine();