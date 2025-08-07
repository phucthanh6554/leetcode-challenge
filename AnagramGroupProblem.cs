namespace Leetcode.Algorithm;

public class AnagramGroupProblem
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var dic = new Dictionary<int, IList<string>>();

        foreach (var str in strs)
        {
            var sum = SumString(str);

            var found = dic.TryGetValue(sum, out var list);
            
            if(!found)
                dic.Add(sum, new List<string>{str});
            else
                list.Add(str);
        }
        
        return dic.Values.ToList();
    }

    private int SumString(ReadOnlySpan<char> str)
    {
        var sum = 0;
        foreach(var c in str)
        {
            sum += c - 'a' + 1;
        }
        
        return sum;
    }
}