namespace Leetcode.Algorithm;

public class ReverseBitProblem
{
    public int ReverseBits(int n)
    {
        var result = 0;

        for (var i = 0; i < 32; i++)
        {
            var bit = (n >> i) & 1;
            
            result |= bit << (31 - i);
        }
        
        return result;
    }
}