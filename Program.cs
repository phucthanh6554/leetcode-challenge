using Leetcode.Algorithm;

var service = new SwapNodeInPairProblem();

var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

var result = service.SwapPairs(list);

Console.WriteLine(result);