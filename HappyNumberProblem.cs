namespace Leetcode.Algorithm;

public class HappyNumberProblem
{
    public bool IsHappy(int n)
    {
        var result = n;
        
        var dictionary = new Dictionary<int, bool>();
        
        while (result != 1)
        {
            result = SumOfDigits(result);

            if (!dictionary.TryAdd(result, true))
                return false;
        }

        return true;
    }

    private int SumOfDigits(int n)
    {
        var sum = 0;
        while (n > 0)
        {
            var digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        
        return sum;
    }
}