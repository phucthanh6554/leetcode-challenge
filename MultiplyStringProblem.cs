using System.Text;

namespace Leetcode.Algorithm;

public class MultiplyStringProblem
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";
        
        Span<int> result = stackalloc int[num1.Length + num2.Length];

        for (var i = num1.Length - 1; i >= 0; i--)
        {
            var n1 = num1[i] - '0';
            
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                var n2 = num2[j] - '0';
                
                var product = n1 * n2 + result[i + j + 1];
                
                result[i + j + 1] = product % 10;
                result[i + j] += product / 10;
            }
        }
        
        var sb = new StringBuilder();

        int index;

        for (index = 0; index < result.Length; index++)
        {
            if(result[index] != 0)
                break;
        }
        
        for(var i = index; i < result.Length; i++)
            sb.Append(result[i]);
        
        return sb.ToString();
    }
}