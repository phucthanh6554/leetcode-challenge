
using System.Text.RegularExpressions;
using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new AdjacentIncresingSubArrayProblem();

var max = service.HasIncreasingSubarrays(new List<int> { -15, 19 }, 1);


Console.WriteLine();