namespace Leetcode.Algorithm;

public class IsomorphicStringsProblem
{
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var dictionary = new Dictionary<char, char>();

        var result = string.Empty;

        for(var i = 0; i < s.Length; i++) {
            if(!dictionary.ContainsKey(s[i]) && !dictionary.ContainsValue(t[i]))
                dictionary.Add(s[i], t[i]);
            
            if(!dictionary.TryGetValue(s[i], out var c))
                return false;

            result += c;
        }

        Console.WriteLine(result);

        return result == t;
    }
}