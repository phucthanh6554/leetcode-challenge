using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new FindXSumOfAllKLongSubArr();

var max = service.FindXSumImprove(new[] { 3,8,7,8,7,5 }, 2, 2);


Console.WriteLine();