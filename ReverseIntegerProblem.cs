namespace Leetcode.Algorithm;

public class ReverseIntegerProblem
{
    public int Reverse(int x)
    {
        var reversed = 0;
        
        var neutralNumber = x < 0 ? -1 : 1;

        x *= neutralNumber;

        while (x > 0)
        {
            if (reversed > Int32.MaxValue / 10)
                return 0;
            
            reversed = (reversed * 10) + (x % 10);
            x /= 10;
        }
        
        return reversed * neutralNumber;
    }
}