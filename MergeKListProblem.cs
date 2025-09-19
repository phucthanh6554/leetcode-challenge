namespace Leetcode.Algorithm;

public class MergeKListProblem
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;
        
        if(lists.Length == 1)
            return lists[0];
        
        return DivideAndConquer(lists, 0, lists.Length - 1);
    }

    private ListNode DivideAndConquer(ListNode[] lists, int start, int end)
    {
        if (start == end)
            return lists[start];
        
        var mid = (start + end) / 2;
        
        var list1 = DivideAndConquer(lists, start, mid);
        var list2 = DivideAndConquer(lists, mid + 1, end);

        return MergeList(list1, list2);
    }

    private ListNode MergeList(ListNode list1, ListNode list2)
    {
        if(list1 == null && list2 == null)
            return null;
        
        if(list1 == null)
            return list2;
        
        if(list2 == null)
            return list1;

        var dummyHead = new ListNode();
        var current = dummyHead;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            
            current = current.next;
        }
        
        if(list1 != null || list2 != null)
            current.next = list1 ?? list2;
        
        return dummyHead.next;
    }

    private ListNode BruteForce(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return new ListNode();
        
        if(lists.Length == 1)
            return lists[0];
        
        var totalItems = lists.Length;

        var dummyHead = new ListNode();
        var current = dummyHead;
        
        while (totalItems > 0)
        {
            var index = FindMinIndex(lists);
            
            if (index == -1)
                break;
            
            current.next = new ListNode(lists[index].val);
            current = current.next;
            
            lists[index] = lists[index].next;
            
            if(lists[index] == null)
                totalItems--;
        }
        
        return dummyHead.next;
    }

    private int FindMinIndex(ListNode?[] lists)
    {
        var minIndex = -1;
        var minValue = int.MaxValue;

        for (int i = 0; i < lists.Length; i++)
        {
            if(lists[i] == null)
                continue;
            
            if (lists[i]!.val < minValue)
            {
                minIndex = i;
                minValue = lists[i]!.val;
            }
        }
        
        return minIndex;
    }
}