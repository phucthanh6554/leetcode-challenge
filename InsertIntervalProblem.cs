namespace Leetcode.Algorithm;

public class InsertIntervalProblem
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var list = new List<int[]>(intervals);

        var index = list.Count;
        
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i][0] > newInterval[0])
            {
                index = i;
                break;
            }
        }
        
        list.Insert(index, newInterval);
        
        var current = list[0];
        
        var result = new List<int[]>();

        for (var i = 0; i < list.Count; i++)
        {
            if (current[1] >= list[i][0])
            {
                current[1] = Math.Max(list[i][1], current[1]);
            }
            else
            {
                result.Add(current);
                current = list[i];
            }
        }
        
        result.Add(current);
        
        return result.ToArray();
    }
}