namespace Leetcode.Algorithm;

public class SqrtProblem
{
    public int MySqrt(int x)
    {
        if(x < 2)
            return x;

        var left = 0;
        var right = (x / 2) + 1;

        var result = 0;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            
            long square = (long)mid * mid;
            
            if(square == x)
                return mid;
            
            if(square > x)
                right = mid - 1;
            else
            {
                left = mid + 1;
                result = mid;
            }
        }

        return result;
    }
}