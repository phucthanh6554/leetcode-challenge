
using System.Text.RegularExpressions;
using Leetcode.Algorithm;

var node = new ListNode(1, new ListNode(4, new ListNode(5)));
var node2 = new ListNode(1, new ListNode(3, new ListNode(4)));
var node3 = new ListNode(2, new ListNode(6));

var service = new CaesarCipherProblem();

var arr = new int[] { 9, 3, 4, 1, 5, 2, 7 };

var test = service.Convert("Hello World", 4);

Console.WriteLine();