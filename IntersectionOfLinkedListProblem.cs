namespace Leetcode.Algorithm;

public class IntersectionOfLinkedListProblem
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        var p1 = headA;
        var p2 = headB;

        while (p1 != p2)
        {
            p1 = p1 == null ? headB : p1.next;
            p2 = p2 == null ? headA : p2.next;
        }
        
        return p1;
    }
}