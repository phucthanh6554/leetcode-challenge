using System.Text;

namespace Leetcode.Algorithm;

public class SimplifyPathProblem
{
    public string SimplifyPath(string path) 
    {
        var parts = path.Split('/');

        var numberOfIgnore = 0;
        var result = new StringBuilder();

        for (var i = parts.Length - 1; i >= 0; i--)
        {
            if(parts[i] == string.Empty || parts[i] == ".")
                continue;

            if (parts[i] == "..")
            {
                numberOfIgnore++;
                continue;
            }

            if (numberOfIgnore > 0)
            {
                numberOfIgnore--;
                continue;
            }
            
            result.Insert(0, parts[i]);
            result.Insert(0, '/');
        }
        
        var str = result.ToString();

        if (str == string.Empty)
            str += '/';

        return str;
    }
}