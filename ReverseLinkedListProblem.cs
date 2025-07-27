namespace Leetcode.Algorithm;

public class ReverseLinkedListProblem
{
    public ListNode ReverseList(ListNode? head) {
        if(head == null || head.next == null)
            return head;

        var stack = new Stack<ListNode>();

        while(head != null)
        {
            stack.Push(head);
            head = head.next;
        }

        var result = stack.Pop();
        var curr = result;

        while(stack.Count > 0) {
            var node = stack.Pop();
            node.next = null;
            curr.next = node;
            curr = curr.next;
        }

        return result;
    }
}