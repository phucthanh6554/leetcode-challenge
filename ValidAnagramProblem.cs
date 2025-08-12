namespace Leetcode.Algorithm;

public class ValidAnagramProblem
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
            return false;
        
        Span<byte> arr1 = stackalloc byte[26];
        Span<byte> arr2 = stackalloc byte[26];

        for (var i = 0; i < s.Length; i++)
        {
            arr1[s[i] - 'a'] += 1;
            arr2[t[i] - 'a'] += 1;
        }

        for (var i = 0; i < arr1.Length; i++)
        {
            if(arr1[i] != arr2[i])
                return false;
        }
        
        return true;
    }
}