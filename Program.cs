using Leetcode.Algorithm;

var service = new IntersectionOfLinkedListProblem();

var nodes = new List<ListNode>
{
    new ListNode(4),
    new ListNode(1),
    new ListNode(8),
    new ListNode(4),
    new ListNode(5),
    new ListNode(5),
    new ListNode(6),
    new ListNode(1),
};

var head1 = nodes[0];
var head2 = nodes[5];

nodes[0].next = nodes[1];
nodes[1].next = nodes[2];
nodes[2].next = nodes[3];
nodes[3].next = nodes[4];

nodes[5].next = nodes[6];
nodes[6].next = nodes[7];
nodes[7].next = nodes[2];

var result = service.GetIntersectionNode(head1, head2);

Console.WriteLine();