namespace Leetcode.Algorithm;

public class ValidParentheses
{
    private static readonly Dictionary<char, char> _parentheses = new()
    {
        ['{'] = '}',
        ['('] = ')',
        ['['] = ']'
    };
    
    // My first solution
    public bool IsValid(string s)
    {
        if(s.Length % 2 != 0)
            return false;
        
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (_parentheses.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }
            
            if(stack.Count == 0)
                return false;
            
            var previousOpenChar = stack.Pop();
            
            if(_parentheses[previousOpenChar] != c)
                return false;
        }
        
        return stack.Count == 0;
    }
}