using System.Text;

namespace Leetcode.Algorithm;

public class ZigZagConversation
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        
        var rows = new List<char>[numRows];

        var currentRow = 0;
        var isGoDown = true;
        

        for (var i = 0; i < s.Length; i++)
        {
            rows[currentRow] ??= new List<char>();
            rows[currentRow].Add(s[i]);
            
            if(isGoDown)
                currentRow++;
            else
                currentRow--;

            if (currentRow == numRows - 1)
                isGoDown = false;
            else if (currentRow == 0)
                isGoDown = true;
        }

        var result = new StringBuilder();
        foreach (var row in rows)
        {
            result.Append(string.Join("", row));
        }
        
        return result.ToString();
    }
}