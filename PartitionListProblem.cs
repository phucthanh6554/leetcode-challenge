namespace Leetcode.Algorithm
{
    public class PartitionListProblem
    {
        public ListNode Partition(ListNode head, int x)
        {
            var dummyHead = new ListNode(-1, head);

            ListNode? largerTargetHead = null;
            ListNode? latestLargerTargetNode = null;
            ListNode? latestLessThanNode = null;

            var node = dummyHead.next;
            var currentHead = dummyHead;

            while(node != null)
            {
                if(node.val < x)
                {
                    currentHead = node;
                    node = node.next;
                }
                else
                {
                    largerTargetHead ??= node;

                    if(latestLargerTargetNode != null)
                        latestLargerTargetNode.next = node;

                    while(node != null && node.val >= x)
                    {
                        if(node.val >= x)
                            latestLargerTargetNode = node;

                        node = node.next;
                    }

                    latestLargerTargetNode.next = null;

                    currentHead.next = node;
                }
            }

            currentHead.next = largerTargetHead;

            return dummyHead.next;
        }
    }
}
