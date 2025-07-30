namespace Leetcode.Algorithm;

public class RemoveNthNodeFromEndProblem
{
    public ListNode RemoveNthFromEnd(ListNode? head, int n)
    {
        var dummyHead = new ListNode(0, head);
        
        var current = dummyHead;
        var faster = dummyHead;

        var i = n + 1;
        while (i > 0 && faster != null)
        {
            faster = faster.next;
            i--;
        }

        while (faster != null)
        {
            current = current!.next;
            faster = faster.next;
        }

        current.next = current.next.next;
        
        return dummyHead.next;
    }
}