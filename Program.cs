
using System.Text.RegularExpressions;
using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new ConvertSortedListToBstProblem();

var result = service.SortedListToBST(node);

Console.WriteLine();