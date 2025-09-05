using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new RestoreIpAddressProblem();

var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

var result = service.RestoreIpAddresses("0000");

Console.WriteLine();