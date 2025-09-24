namespace Leetcode.Algorithm;

public class ReorderListProblem
{
    public void ReorderList(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // reverse 
        ListNode? current = null;
        var node = slow;

        while (node != null)
        {
            var temp = node.next;
            node.next = current;
            current = node;
            node = temp;
        }

        var first = head;
        var second = current;

        while (second != null)
        {
            var temp1 = first.next;
            var temp2 = second.next;
            
            first.next = second;
            second.next = temp1;

            first = temp1;
            second = temp2;
        }
    }
}