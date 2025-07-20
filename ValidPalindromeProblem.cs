using System.Text.RegularExpressions;

namespace Leetcode.Algorithm;

public class ValidPalindromeProblem
{
    public bool IsPalindrome(string s)
    {
        var i = 0;
        var j = s.Length - 1;

        while (i < j)
        {
            var char1 = IsAlphanumeric(s[i]);
            var char2 = IsAlphanumeric(s[j]);
            
            if (!char1.isValid)
                i++;
            else if (!char2.isValid)
                j--;
            else if (char1.ascii != char2.ascii)
                return false;
            else
            {
                i++;
                j--;
            }
        }
        
        return true;
    }

    private (bool isValid, int ascii) IsAlphanumeric(char s)
    {
        var ascii = (int)s;

        if (ascii <= 57)
        {
            ascii -= 48;
            return (ascii >= 0 && ascii <= 9, ascii);
        }
        
        ascii = ascii >= 97 ? ascii - 32 : ascii;
        return (ascii >= 65 && ascii <= 90, ascii);
    }
}