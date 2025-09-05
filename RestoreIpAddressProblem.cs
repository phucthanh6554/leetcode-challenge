namespace Leetcode.Algorithm;

public class RestoreIpAddressProblem
{
    public IList<string> RestoreIpAddresses(string s) 
    {
        var path = new List<string>();
        var result = new List<string>();
        
        Backtrack(s, 0, path, result);
        
        return result;
    }

    private void Backtrack(ReadOnlySpan<char> s, int index, List<string> path, List<string> result)
    {
        if (path.Count == 4 && index == s.Length)
        {
            result.Add(string.Join('.', path));
            return;
        }

        if (path.Count == 4)
            return;

        for (var len = 1; len <= 3 && index + len <= s.Length; len++)
        {
            if(s[index] == '0' && len > 1)
                break;
            
            var candidate = s.Slice(index, len);
            var number = int.Parse(candidate);
            
            if(number > 255)
                break;
            
            path.Add(candidate.ToString());
            Backtrack(s, index + len, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}