using Leetcode.Algorithm;

var service = new LinkedListCycleProblem();

var head = new ListNode(4);
var node1 = new ListNode(2);
var node2 = new ListNode(0);
var node3 = new ListNode(4);

head.next = node1;
node1.next = node2;
node2.next = node3;
node3.next = node1;

var result = service.HasCycle(head);

Console.WriteLine();