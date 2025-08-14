using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new RotateListProblem();

var node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

var result = service.RotateRight(node, 5);

Console.WriteLine();