namespace Leetcode.Algorithm;

public class ExcelSheetColumnNumberProblem
{
    public int TitleToNumber(string columnTitle) 
    {
        var result = 0;

        foreach (var c in columnTitle)
        {
            result *= 26;
            result += c - 'A';
            result += 1;
        }
        
        return result;
    }
}