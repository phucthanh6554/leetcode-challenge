using System.Text;

namespace Leetcode.Algorithm;

public class CaesarCipherProblem
{
    public string Convert(string s, int num)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        var sb = new StringBuilder();

        foreach (var c in s)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                char newLetter;

                if (char.IsUpper(c))
                    newLetter = (char) ('A' + ((c - 'A' + num + 26) % 26));
                else
                    newLetter = (char) ('a' + (c - 'a' + num + 26) % 26);
                
                sb.Append(newLetter);
                continue;
            }
            
            sb.Append(c);
        }
        
        return sb.ToString();
    }
}