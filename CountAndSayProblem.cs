namespace Leetcode.Algorithm;

public class CountAndSayProblem
{
    public string CountAndSay(int n) 
    {
        var result = "111221";

        for (var i = 1; i < n; i++)
        {
            var count = 0;
            char prev = result[0];

            var temp = string.Empty;

            for (var j = 0; j < result.Length; j++)
            {
                if(result[j] == prev)
                    count++;
                else
                {
                    temp += $"{count}{prev}";
                    prev = result[j];
                    count = 1;
                }
            }
            
            if (count > 0)
                temp += $"{count}{prev}";

            result = temp;
        }

        return result;
    }

    private string CountAndSayRecursive(int n)
    {
        if (n == 1)
            return "1";

        if (n % 2 == 0)
            return "1" + CountAndSayRecursive(n - 1);
        
        return "2" + CountAndSayRecursive(n - 1);
    }
}