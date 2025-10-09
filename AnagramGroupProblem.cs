using System.Text;

namespace Leetcode.Algorithm;

public class AnagramGroupProblem
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var hash = CreateHash(str);
            
            if(!result.ContainsKey(hash))
                result.Add(hash, new List<string> {str});
            else
                result[hash].Add(str);
        }
        
        return result.Values.ToList();
    }

    private string CreateHash(ReadOnlySpan<char> str)
    {
        Span<int> hash = stackalloc int[26];

        foreach (var c in str)
        {
            hash[c - 'a']++;
        }

        var sb = new StringBuilder();

        foreach (var c in hash)
        {
            sb.Append('-');
            sb.Append(c);
        }
        
        return sb.ToString();
    }
}