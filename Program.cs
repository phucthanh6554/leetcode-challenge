
using System.Text.RegularExpressions;
using Leetcode.Algorithm;

var node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7)))))));

var service = new ReorderListProblem();

service.ReorderList(node);

Console.WriteLine();