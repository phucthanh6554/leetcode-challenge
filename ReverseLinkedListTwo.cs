namespace Leetcode.Algorithm;

public class ReverseLinkedListTwo
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null || head.next == null || left > right)
            return head;
        
        var dummyHead = new ListNode(-1, head);

        ListNode? previousLeftHead = null;
        var leftHead = dummyHead;

        for (var i = 0; i < left; i++)
        {
            previousLeftHead = leftHead;
            leftHead = leftHead.next;
        }

        var pointer = leftHead;

        ListNode? tempNode = null;
        ListNode? nextNode = null;
        for (var i = left; i <= right; i++)
        {
            nextNode = pointer.next;
            pointer.next = tempNode;
            tempNode = pointer;
            pointer = nextNode;
        }

        previousLeftHead.next = tempNode;
        leftHead.next = nextNode;
        
        return dummyHead.next;
    }
}