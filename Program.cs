using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new MakeArrayElementsEqualToZeroProblem();

var max = service.CountValidSelections(new[] { 2,3,4,0,4,1,0 });


Console.WriteLine();