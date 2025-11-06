namespace Leetcode.Algorithm;

/// <summary>
/// https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-i/description/?envType=daily-question&envId=2025-11-04
/// </summary>
public class FindXSumOfAllKLongSubArr
{
    public struct Pair
    {
        public long Num { get; set; }
        
        public long Frequent { get; set; }

        public Pair(long num , long freq)
        {
            Num = num;
            Frequent = freq;
        }
    }
    
    public class PairAscendingComparer : IComparer<Pair>
    {
        public int Compare(Pair x, Pair y)
        {
            if (x.Frequent == y.Frequent)
                return x.Num.CompareTo(y.Num);
            
            return x.Frequent.CompareTo(y.Frequent);
        }
    }

    public class PairDescendingComparer : IComparer<Pair>
    {
        public int Compare(Pair x, Pair y)
        {
            if (x.Frequent == y.Frequent)
                return y.Num.CompareTo(x.Num);
            
            return y.Frequent.CompareTo(x.Frequent);
        }
    }
    
    public long[] FindXSumImprove(int[] nums, int k, int x)
    {
        var result = new long[nums.Length - k + 1];
        
        var dict = new Dictionary<int, int>();
        
        var comparer = new PairDescendingComparer();
        
        var topX = new SortedSet<Pair>(new PairAscendingComparer());
        var rest  = new SortedSet<Pair>(comparer);

        long sum = 0;
        
        for (var i = 0; i < k; i++)
        {
            Add(nums[i]);
        }
        
        result[0] = sum;

        for (var i = 1; i <= nums.Length - k; i++)
        {
            Remove(nums[i - 1]);
            Add(nums[i + k - 1]);
            
            result[i] = sum;
        }

        return result;

        void Add(int n)
        {
            dict.TryGetValue(n, out var oldFred);
            
            dict.TryAdd(n, 0);
            dict[n]++;

            if (oldFred != 0)
            {
                var oldPair = new Pair(n, oldFred);
                
                if (topX.Contains(oldPair))
                {
                    topX.Remove(oldPair);
                    sum -= oldPair.Frequent * oldPair.Num;
                }
                else if (rest.Contains(oldPair))
                {
                    rest.Remove(oldPair);
                }
            }
            
            var newPair = new Pair(n, dict[n]);

            topX.Add(newPair);
            sum += newPair.Frequent * newPair.Num;

            if (topX.Count > x)
            {
                var smallest = topX.Min;
                topX.Remove(smallest);
                rest.Add(smallest);
                sum -= smallest.Frequent * smallest.Num;
            }

            if (topX.Count < x && rest.Count > 0)
            {
                var largest = rest.Min;
                rest.Remove(largest);
                
                topX.Add(largest);
                sum += largest.Frequent * largest.Num;
            }
        }

        void Remove(int n)
        {
            var oldFred = dict[n];
            dict[n]--;
            
            var oldPair = new Pair(n, oldFred);

            if (topX.Contains(oldPair))
            {
                topX.Remove(oldPair);
                sum -= oldPair.Frequent * oldPair.Num;
            }else if (rest.Contains(oldPair))
            {
                rest.Remove(oldPair);
            }
            
            var newPair = new Pair(n, dict[n]);
            rest.Add(newPair);
            
            if (topX.Count > x)
            {
                var smallest = topX.Min;
                topX.Remove(smallest);
                rest.Add(smallest);
                sum -= smallest.Frequent * smallest.Num;
            }
            
            if (topX.Count < x && rest.Count > 0)
            {
                var largest = rest.Min;
                rest.Remove(largest);
                
                topX.Add(largest);
                sum += largest.Frequent * largest.Num;
            }
        }
    }
    
    public int[] FindXSum(int[] nums, int k, int x) 
    {
        var result = new int[nums.Length - k + 1];
        
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < k; i++)
        {
            dict.TryAdd(nums[i], 0);
            dict[nums[i]]++;
        }

        for (var i = 0; i <= nums.Length - k; i++)
        {
            if (i != 0)
            {
                dict[nums[i - 1]]--;
                dict.TryAdd(nums[i + k - 1], 0);
                dict[nums[i + k - 1]]++;
            }
            
            var sum = dict
                .OrderByDescending(pair => pair.Value)
                .ThenByDescending(pair => pair.Key)
                .Take(x)
                .Sum(pair => pair.Key * pair.Value);
            
            result[i] = sum;
        }
        
        return result;
    }
}