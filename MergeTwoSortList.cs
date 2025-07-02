namespace Leetcode.Algorithm;

public class MergeTwoSortList
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
            return null;
        
        if (list1 == null)
            return list2;
        
        if (list2 == null)
            return list1;

        var result = new ListNode();
        ListNode? newNode = result;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                newNode.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                newNode.val = list2.val;
                list2 = list2.next;
            }

            if (list1 != null && list2 != null)
            {
                newNode.next = new ListNode();
                newNode = newNode.next;
            }
        }
        
        newNode.next = list1 ?? list2;
        
        return result;
    }
    
    public class ListNode {
        public int val;
        
        public ListNode? next;
        
        public ListNode(int val=0, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }
    }
}

