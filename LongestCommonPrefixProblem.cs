using System.Text;

namespace Leetcode.Algorithm;

public class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != c)
                    return strs[0].Substring(0, i);
            }
        }

        return strs[0];
    }
    
    // My first solution
    // public string LongestCommonPrefix(string[] strs)
    // {
    //     var str1 = strs[0];
    //
    //     var result = string.Empty;
    //     var temp = string.Empty;
    //     for (var i = 0; i < str1.Length; i++)
    //     {
    //         temp += str1[i];
    //
    //         if (!strs.All(x => x.StartsWith(temp)))
    //             return result;
    //         else
    //             result = temp;
    //     }
    //     
    //     return result;
    // }
}