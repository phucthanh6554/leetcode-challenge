namespace Leetcode.Algorithm;

public class DecodeWaysProblem
{
    // 1123
    public int NumDecodings(string s)
    {
        var dp1 = 0;
        var dp2 = 1;

        if (s[^1] != '0')
            dp1 = 1;

        for (var i = s.Length - 2; i >= 0; i--)
        {
            var current = 0;

            if (s[i] != '0')
            {
                current = dp1;
                
                var twoNumber = (s[i] - '0') * 10 + (s[i + 1] - '0');

                if (twoNumber >= 10 && twoNumber <= 26)
                    current += dp2;
            }

            dp2 = dp1;
            dp1 = current;

        }
        
        return dp1;
    }
}