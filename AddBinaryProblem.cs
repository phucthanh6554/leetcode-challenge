using System.Text;

namespace Leetcode.Algorithm;

public class AddBinaryProblem
{
    public string AddBinary(string a, string b) 
    {
        if(string.IsNullOrEmpty(a))
            return b;
        
        if(string.IsNullOrEmpty(b))
            return a;
        
        var bufferString = new string('0', Math.Abs(a.Length - b.Length));
        
        if(a.Length < b.Length)
            a = bufferString + a;
        else
            b = bufferString + b;
        
        var maxLength = Math.Max(a.Length, b.Length);
        var result = new StringBuilder();

        var carry = 0;
        for (var i = maxLength - 1; i >= 0; i--)
        {
            var num1 = a[i] - '0';
            var num2 = b[i] - '0';
            
            var num3 = num1 + num2 + carry;

            result.Insert(0, num3 % 2);
            carry = num3 / 2;
        }
        
        if (carry > 0)
            result.Insert(0, carry);
        
        return result.ToString();
    }
}