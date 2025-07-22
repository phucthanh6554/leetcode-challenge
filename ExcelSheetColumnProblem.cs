using System.Text;

namespace Leetcode.Algorithm;

public class ExcelSheetColumnProblem
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = new StringBuilder();

        while (columnNumber > 0)
        {
            columnNumber -= 1;

            result.Insert(0, (char)(columnNumber % 26 + 'A'));
            columnNumber /= 26;
        }
        
        return result.ToString();
    }
}