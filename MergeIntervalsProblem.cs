namespace Leetcode.Algorithm;

public class MergeIntervalsProblem
{
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals.Length <= 1)
            return intervals;
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        var current  = intervals[0];
        var merged = new List<int[]>(intervals.Length);

        foreach (var interval in intervals)
        {
            if(interval[0] <= current[1])
                current[1] = Math.Max(interval[1], current[1]);
            else
            {
                merged.Add(current);
                current = interval;
            }
        }
        
        merged.Add(current);
        
        return merged.ToArray();
    }
}