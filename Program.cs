using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new PowerGridMaintenanceProblem();

var connections = new int[][]
{
    //[4,3],[3,1],[4,2],[3,2],[4,1]
    //[1,2],[2,3],[3,4],[4,5]
    //[2,3],[1,3],[4,1],[3,4]
    //[1,2],[4,3],[7,3],[1,7],[7,6],[2,6]
};

int[][] queries = new int[][] {
    //[2,3],[1,2],[2,4],[1,1],[2,2],[1,2],[1,2],[2,2],[1,3],[2,3],[2,4],[2,3],[2,4],[1,2],[1,1]
    //[1,3],[2,1],[1,1],[2,2],[1,2]
    //[1,2],[2,4],[2,1],[1,4],[2,1],[1,1],[2,2],[1,4],[2,1],[2,2],[2,3],[2,4],[2,1],[1,1],[2,3],[2,2],[2,3],[1,4],[2,4]
    [1,1],[2,1],[1,1]
    //[1,1],[2,5],[1,1],[2,1],[2,4],[1,4],[2,2]
};

var max = service.ProcessQueries(3, connections, queries);


Console.WriteLine();