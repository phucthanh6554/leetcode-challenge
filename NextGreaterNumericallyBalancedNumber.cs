namespace Leetcode.Algorithm;

//https://leetcode.com/problems/next-greater-numerically-balanced-number/?envType=daily-question&envId=2025-10-24
public class NextGreaterNumericallyBalancedNumber
{
    public int NextBeautifulNumber(int n)
    {
        n += 1;

        while (true)
        {
            if (IsBeautifulNumber(n))
                return n;

            n++;
        }

        return 0;
    }

    private bool IsBeautifulNumber(int n)
    {
        var dict = new Dictionary<int, int>();

        while (n > 0)
        {
            var temp = n % 10;
            dict.TryAdd(temp, 0);
            dict[temp]++;

            n /= 10;
        }

        foreach (var kvp in dict)
        {
            if(kvp.Key != kvp.Value)
                return false;
        }
        
        return true;
    }
}