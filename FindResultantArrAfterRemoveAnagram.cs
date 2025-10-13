namespace Leetcode.Algorithm;

public class FindResultantArrAfterRemoveAnagram
{
    public IList<string> RemoveAnagrams(string[] words) 
    {
        var result = new List<string>();

        var i = 0;

        while (i < words.Length)
        {
            result.Add(words[i]);

            var word = words[i];

            i++;
            
            if(i >= words.Length)
                break;

            while (i < words.Length && IsAnagram(words[i], word))
                i++;
        }
        
        return result;
    }

    private bool IsAnagram(string s1, string s2)
    {
        if(s1.Length != s2.Length)
            return false;
        
        var arr = new char[26];
        var arr2 = new char[26];

        for (int i = 0; i < s1.Length; i++)
        {
            arr[s1[i] - 'a']++;
            arr2[s2[i] - 'a']++;
        }

        var a1 = string.Join('-', arr);
        var a2 = string.Join('-', arr2);
        
        return a1 == a2;
    }
}