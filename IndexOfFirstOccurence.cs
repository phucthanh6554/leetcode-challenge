namespace Leetcode.Algorithm;

public class IndexOfFirstOccurence
{
    public int StrStr(string haystack, string needle) 
    {
        if(haystack.Length < needle.Length)
            return -1;

        var result = -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            var match = true;
            for (var j = 0; j < needle.Length; j++)
            {
                if(i + j > haystack.Length - 1)
                    return -1;
                
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                result = i;
                break;
            }
        }
        
        return result;
    }
}