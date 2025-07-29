namespace Leetcode.Algorithm;

public class StringToIntegerProblem
{
    public int MyAtoi(string s)
    {
        var i = 0;
        var sign = 1;
        var result = 0;

        while (i < s.Length && s[i] == ' ')
            i++;
        
        if(i < s.Length && (s[i] == '+' || s[i] == '-'))
            sign = s[i++] == '-' ? -1 : 1;

        while (i < s.Length)
        {
            if(result > Int32.MaxValue / 10)
                return sign < 0 ? Int32.MinValue : Int32.MaxValue;

            if (s[i] < '0' || s[i] > '9')
                return result * sign;
            
            var ascii = s[i] - '0';
            result = result * 10 + ascii;
            i++;
        }
        
        return result * sign;
    }
}