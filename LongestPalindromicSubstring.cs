namespace Leetcode.Algorithm;

public class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        var maxString = string.Empty;
        
        for (var i = 0; i < s.Length; i++)
        {
            var str1 = ExpandFromCenter(s, i, i);
            
            if(str1.Length > maxString.Length)
                maxString = str1;
            
            var str2 = ExpandFromCenter(s, i, i + 1);
            
            if(str2.Length > maxString.Length)
                maxString = str2;
        }
        
        return maxString;
    }

    private string ExpandFromCenter(string s, int x, int y)
    {
        while (x >= 0 && y < s.Length && s[x] == s[y])
        {
            x--;
            y++;
        }
        
        return s.Substring(x + 1, y - x - 1);
    }
}