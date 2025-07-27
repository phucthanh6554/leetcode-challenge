namespace Leetcode.Algorithm;

public class PartitionArrayWithPivot
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        var list = new LinkedList<int>();
        
        var pivotNode = list.AddFirst(pivot);
        var latestPivot = pivotNode;
        LinkedListNode<int>? currentGreatestNode = null;

        var foundPivot = true;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == pivot && foundPivot)
            {
                foundPivot = false;
                continue;
            }
            
            if(nums[i] == pivot)
            {
                var newNode = new LinkedListNode<int>(nums[i]);
                list.AddAfter(latestPivot, newNode);
                latestPivot = newNode;
            }
            else if(nums[i] < pivot)
                list.AddBefore(pivotNode, new LinkedListNode<int>(nums[i]));
            else if (currentGreatestNode == null)
            {
                currentGreatestNode = new LinkedListNode<int>(nums[i]);
                list.AddAfter(latestPivot, currentGreatestNode);
            }
            else
            {
                var newNode = new LinkedListNode<int>(nums[i]);
                list.AddAfter(currentGreatestNode, newNode);
                currentGreatestNode = newNode;
            }
        }
        
        return list.ToArray();
    }
}