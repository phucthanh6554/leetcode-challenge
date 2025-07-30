namespace Leetcode.Algorithm;

public class DivideTwoIntegerProblem
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;
        
        long dividendAsLong = dividend;
        long divisorAsLong = divisor;
        
        dividendAsLong = Math.Abs(dividendAsLong);
        divisorAsLong = Math.Abs(divisorAsLong);

        var result = 0;

        while (dividendAsLong >= divisorAsLong)
        {
            var temp = divisorAsLong;
            var multiplier = 1;

            while (dividendAsLong >= (temp << 1))
            {
                temp <<= 1;
                multiplier <<= 1;
            }
            
            dividendAsLong -= temp;
            result += multiplier;
        }

        var hasSign = (dividend < 0) ^ (divisor < 0);

        if (hasSign)
            return -result;

        return result;
    }
}