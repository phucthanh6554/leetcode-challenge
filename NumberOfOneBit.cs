namespace Leetcode.Algorithm;

public class NumberOfOneBit
{
    public int HammingWeight(int n) 
    {
        var result = 0;
        var num = n;

        var i = 0;
        while (num > 0)
        {
            result += (n >> i) & 1;
            num >>= 1;
            i++;
        }
        
        return result;
    }
}