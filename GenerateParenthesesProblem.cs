namespace Leetcode.Algorithm;

public class GenerateParenthesesProblem
{
    public IList<string> GenerateParenthesis(int n) 
    {
        var result = new List<string>();
        Backtrack(n, string.Empty, 0, 0, result);
        
        return result;
    }

    private void Backtrack(int n, string s, int open, int close, List<string> result)
    {
        if (n == open && n == close)
        {
            result.Add(s);
            return;
        }
        
        if(open < n)
            Backtrack(n, s + '(', open + 1, close, result);
        
        if(close < open)
            Backtrack(n, s + ')', open, close + 1, result);
    }
}