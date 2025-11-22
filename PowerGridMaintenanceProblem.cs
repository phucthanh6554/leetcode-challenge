namespace Leetcode.Algorithm;

public class PowerGridMaintenanceProblem
{
    public int[] ProcessQueries(int c, int[][] connections, int[][] queries)
    {
        var parent = new int[c + 1];
        
        for(var i = 0; i <= c; i++)
            parent[i] = i;

        int Find(int x)
        {
            if(parent[x] != x)
                parent[x] = Find(parent[x]);
            
            return parent[x];
        }

        void Union(int x, int y)
        {
            var rx = Find(x);
            var ry = Find(y);
            
            if(rx != ry)
                parent[ry] = rx;
        }

        foreach (var conn in connections)
        {
            Union(conn[0], conn[1]);
        }

        var dict = new Dictionary<int, SortedSet<int>>();

        for (var i = 1; i <= c; i++)
        {
            var r = Find(i);
            
            if(!dict.ContainsKey(r))
                dict.Add(r, new SortedSet<int>());

            dict[r].Add(i);
        }
        
        var isOnline = new bool[c + 1];
        Array.Fill(isOnline, true);
        
        var result = new List<int>();

        foreach (var query in queries)
        {
            if (IsSetOffline(query))
                isOnline[query[1]] = false;
            else
            {
                if(isOnline[query[1]])
                    result.Add(query[1]);
                else{
                    var r = Find(query[1]);
                
                    while(dict[r].Count > 0 && !isOnline[dict[r].Min])
                        dict[r].Remove(dict[r].Min);
                    
                    if(dict[r].Count == 0)
                        result.Add(-1);
                    else 
                        result.Add(dict[r].Min);
                }
            }
        }
        
        return result.ToArray();
    }

    private int[] MySecondStupidSolution(int c, int[][] connections, int[][] queries)
    {
        var adjArr = new List<int>[c + 1];

        for (var i = 0; i <= c; i++)
            adjArr[i] = new List<int>();

        foreach (var conn in connections)
        {
            adjArr[conn[0]].Add(conn[1]);
            adjArr[conn[1]].Add(conn[0]);
        }

        var result = new List<int>();

        var isOffline = new bool[c + 1];

        foreach (var q in queries)
        {
            if (IsSetOffline(q))
                isOffline[q[1]] = true;
            else if (IsMaintenance(q))
            {
                result.Add(Bfs(q[1]));
            }
        }

        return result.ToArray();

        int Bfs(int startStation)
        {
            if (isOffline[startStation] == false)
                return startStation;

            var visited = new bool[c + 1];

            var queue = new Queue<int>();
            visited[startStation] = true;

            queue.Enqueue(startStation);

            var min = int.MaxValue;

            while (queue.Count > 0)
            {
                var s = queue.Dequeue();

                if (isOffline[s] == false)
                    min = Math.Min(min, s);

                foreach (var neighbor in adjArr[s])
                {
                    if (visited[neighbor])
                        continue;

                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
                }
            }

            return min < int.MaxValue ? min : -1;
        }
    }

    private int[] MyStupidSolution(int c, int[][] connections, int[][] queries)
    {
        // Create a 2 dimension boolean array
        // Loop the connection to fill data into the array
        // Loop the queries 

        var arr = new bool[c, c];

        for (var i = 0; i < c; i++)
            arr[i, i] = true;

        foreach (var conn in connections)
        {
            arr[conn[0] - 1, conn[1] - 1] = true;
            arr[conn[1] - 1, conn[0] - 1] = true;
        }

        var result = new List<int>();

        foreach (var q in queries)
        {
            if (IsSetOffline(q))
            {
                arr[q[1] - 1, q[1] - 1] = false;
            }
            else if (IsMaintenance(q))
            {
                var candidate = StupidBFS(arr, q[1]);
                result.Add(candidate);
            }
        }

        return result.ToArray();
    }

    private int StupidBFS(bool[,] arr, int station)
    {
        if (arr[station - 1, station - 1])
            return station;

        var queue = new Queue<int>();

        var min = int.MaxValue;

        queue.Enqueue(station);

        var used = new bool[arr.GetLength(0)];

        used[station - 1] = true;

        while (queue.Count > 0)
        {
            var s = queue.Dequeue();

            if (arr[s - 1, s - 1] && s < min)
                min = s;

            for (var i = 1; i <= arr.GetLength(1) && i <= min; i++)
            {
                if (used[i - 1])
                    continue;

                if (arr[s - 1, i - 1])
                {
                    queue.Enqueue(i);
                    used[i - 1] = true;
                }
            }
        }

        return min < int.MaxValue ? min : -1;
    }

    private int FindCandidate(bool[,] arr, int station, bool[] isUsed)
    {
        if (arr[station - 1, station - 1])
            return station;

        if (isUsed.All(x => x == true))
            return -1;

        var min = -1;

        for (var i = 1; i <= arr.GetLength(1); i++)
        {
            if (arr[station - 1, i - 1] && arr[i - 1, i - 1])
                min = min == -1 ? i : Math.Min(min, i);

            if (isUsed[i - 1])
                continue;

            if (i == station || !arr[station - 1, i - 1])
                continue;

            isUsed[i - 1] = true;

            var currentMin = FindCandidate(arr, i, isUsed);

            min = min == -1 ? currentMin : Math.Min(min, currentMin);
        }

        return min;
    }

    private bool IsMaintenance(int[] q)
    {
        return q[0] == 1;
    }

    private bool IsSetOffline(int[] q)
    {
        return q[0] == 2;
    }
}
//
// // DSU parent
//         var parent = new int[c + 1];
//         for (int i = 1; i <= c; i++)
//             parent[i] = i;
//
//         int Find(int x)
//         {
//             if (parent[x] != x)
//                 parent[x] = Find(parent[x]);
//             return parent[x];
//         }
//
//         void Union(int a, int b)
//         {
//             int ra = Find(a);
//             int rb = Find(b);
//             if (ra != rb)
//                 parent[rb] = ra;
//         }
//
//         // Build components
//         foreach (var conn in connections)
//         {
//             Union(conn[0], conn[1]);
//         }
//
//         // For each component root, maintain a min-heap of online station IDs
//         var online = new bool[c + 1];
//         for (int i = 1; i <= c; i++)
//             online[i] = true;
//
//         var compHeap = new Dictionary<int, PriorityQueue<int, int>>();
//
//         for (int i = 1; i <= c; i++)
//         {
//             int r = Find(i);
//             if (!compHeap.ContainsKey(r))
//                 compHeap[r] = new PriorityQueue<int, int>();
//             compHeap[r].Enqueue(i, i);
//         }
//
//         var resultList = new List<int>();
//
//         foreach (var q in queries)
//         {
//             int type = q[0];
//             int x = q[1];
//
//             if (type == 2)
//             {
//                 // set x offline
//                 online[x] = false;
//             }
//             else if (type == 1)
//             {
//                 if (online[x])
//                 {
//                     resultList.Add(x);
//                 }
//                 else
//                 {
//                     int r = Find(x);
//                     var heap = compHeap[r];
//                     // pop until find an online station
//                     while (heap.Count > 0 && !online[heap.Peek()])
//                     {
//                         heap.Dequeue();
//                     }
//                     if (heap.Count == 0)
//                         resultList.Add(-1);
//                     else
//                         resultList.Add(heap.Peek());
//                 }
//             }
//         }
//
//         return resultList.ToArray();