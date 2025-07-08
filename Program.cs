using Leetcode.Algorithm;

var service = new RemoveDuplicateSortedLinkedList();

var result = service.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))));

Console.WriteLine(result);
