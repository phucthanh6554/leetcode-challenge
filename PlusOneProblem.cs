namespace Leetcode.Algorithm;

public class PlusOneProblem
{
    public int[] PlusOne(int[] digits) 
    {
        var length = digits.Length;

        for (var i = length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            
            digits[i] = 0;
        }
        
        var result = new int[length + 1];
        result[0] = 1;
        return result;
    }
    
    // public int[] PlusOne(int[] digits) {
    //     var stack = new Stack<int>();
    //
    //     digits[^1] += 1;
    //     var isIncreasing = digits[^1] > 9;
    //     
    //     for (var i = digits.Length - 1; i >= 0; i--)
    //     {
    //         var digit = digits[i];
    //         
    //         if (isIncreasing)
    //         {
    //             digit += 1;
    //             isIncreasing = false;
    //         }
    //
    //         if (digit > 9)
    //         {
    //             isIncreasing = true;
    //             digit = 0;
    //         }
    //         
    //         stack.Push(digit);
    //     }
    //     
    //     if(isIncreasing)
    //         stack.Push(1);
    //     
    //     return stack.ToArray();
    // }
}