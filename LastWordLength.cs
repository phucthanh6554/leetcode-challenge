namespace Leetcode.Algorithm;

public class LastWordLength
{
    public int LengthOfLastWord(string s) {
        var i = s.Length - 1;

        var foundCharacter = false;
        var result = 0;
        while (i >= 0)
        {
            if(s[i] == ' ' && foundCharacter)
                break;
            if (s[i] == ' ')
            {
                i--;
                continue;
            }
            
            foundCharacter = true;
            result++;
            i--;
        }
        
        return result;
    }
}