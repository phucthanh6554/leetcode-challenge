using Leetcode.Algorithm;

var service = new MergeTwoSortList();

var listNode1 = new MergeTwoSortList.ListNode(1, new MergeTwoSortList.ListNode(2, new MergeTwoSortList.ListNode(3)));
var listNode2 = new MergeTwoSortList.ListNode(1, new MergeTwoSortList.ListNode(2, new MergeTwoSortList.ListNode(7 , new MergeTwoSortList.ListNode(9))));

var result = service.MergeTwoLists(listNode1, listNode2);

Console.WriteLine(result);
