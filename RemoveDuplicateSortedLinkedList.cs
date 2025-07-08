namespace Leetcode.Algorithm;

public class RemoveDuplicateSortedLinkedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return head;
        
        var node = head;
        var currentValue = node.val;

        var nextNode = node.next;
        
        while (node != null && nextNode != null)
        {
            if (currentValue == nextNode.val)
            {
                node.next = nextNode.next;
                nextNode = nextNode.next;
            }
            else
            {
                node = node.next;
                nextNode = node.next;
            }
            
            currentValue = node.val;
        }

        return head;
    }
}