namespace Leetcode.Algorithm;

public class PalindromeLinkedListProblem
{
    public bool IsPalindrome(ListNode head)
    {
        if (head.next == null)
            return true;

        var slow = head;
        var fast = head;

        while (slow != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        if(fast != null)
            slow = slow.next;

        var reversedHead = Reverse(slow);

        while (reversedHead != null)
        {
            if(head.val != reversedHead.val)
                return false;
            
            reversedHead = reversedHead.next;
            head = head.next;
        }

        return true;
    }

    private ListNode Reverse(ListNode head)
    {
        ListNode current = null;
        
        var node = head;

        while (node != null)
        {
            var temp = node.next;
            node.next = current;
            current = node;
            node = temp;
        }
        
        return current;
    }
}