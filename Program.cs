using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new AdjacentIncresingSubArrayProblemTwo();

var max = service.MaxIncreasingSubarrays(new List<int> { 5, 8, -2, -1 });


Console.WriteLine();