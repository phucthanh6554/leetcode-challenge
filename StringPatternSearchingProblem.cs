using System.Buffers;

namespace Leetcode.Algorithm;

public class StringPatternSearchingProblem
{
    public int Search(string haystack, string needle)
    {
        var lps = new int[needle.Length];

        var i = 0;
        var j = 0;
        
        BuildLps(lps, needle);

        while (i < haystack.Length && j < needle.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;

                if (j == needle.Length)
                    return i - j;
            }
            else
            {
                if (j == 0)
                    i++;
                else
                    j = lps[j - 1];
            }
        }

        return -1;
    }
    
    private void BuildLps(int[] lps, string pattern)
    {
        if(pattern.Length == 0)
            return;
        
        lps[0] = 0;

        var j = 1;
        var len = 0;
        
        while (j < pattern.Length)
        {
            if (pattern[j] == pattern[len])
            {
                len++;
                lps[j++] = len;
            }
            else
            {
                if (len == 0)
                    lps[j++] = 0;
                else
                    len = lps[len - 1];
            }
        }
    }
}