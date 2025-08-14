namespace Leetcode.Algorithm;

public class RotateListProblem
{
    public ListNode RotateRight(ListNode head, int k) 
    {
        if(head == null || head.next == null)
            return head;
        
        var temp = head;
        var totalNodes = 0;
        while (temp != null)
        {
            temp = temp.next;
            totalNodes++;
        }

        k = k % totalNodes;
        
        var currentHead = head;

        for (var i = 0; i < k; i++)
        {
            var previousLastNode = currentHead;
            var lastNode = currentHead.next;

            while (lastNode.next != null)
            {
                previousLastNode = previousLastNode.next;
                lastNode = lastNode.next;
            }
        
            lastNode.next = currentHead;
            previousLastNode.next = null;
            currentHead = lastNode;
        }
        
        return currentHead;
    }
}