namespace Leetcode.Algorithm;

public class SwapNodeInPairProblem
{
    public ListNode SwapPairs(ListNode head) 
    {
        var dummyHead = new ListNode(0, head);
        
        var current = dummyHead;
        ListNode? slow = current.next;
        ListNode? fast = slow?.next;

        while (slow != null && fast != null)
        {
            slow.next = fast.next;
            fast.next = slow;
            current.next = fast;

            current = slow;
            slow = current?.next;
            fast = slow?.next;
        }
        
        return dummyHead.next;
    }
}