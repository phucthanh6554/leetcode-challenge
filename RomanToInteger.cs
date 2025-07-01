namespace Leetcode.Algorithm;

public class RomanToInteger
{
    private readonly Dictionary<char, int> _map = new Dictionary<char, int>()
    {
        ['I']= 1,
        ['V']= 5,
        ['X']=  10,
        ['L']=  50,
        ['C']=  100,
        ['D']=  500,
        ['M']=  1000
    };
    
    public int RomanToInt(string s) {
        var result = 0;
        var index = s.Length - 1;

        var previousValue = 0;

        while (index >= 0)
        {
            var current = _map[s[index]];

            if (current >= previousValue)
            {
                result += current;
                previousValue = current;
            }
            else
                result -= current;
            
            index--;
        }

        return result;
    }
    
    // My first solution
    // public int RomanToInt(string s) {
    //     var result = 0;
    //
    //     for (var i = 0; i < s.Length; i++)
    //     {
    //         if (i + 1 < s.Length && IsSubtractCase(s[i], s[i + 1]))
    //         {
    //             result += _map[s[i + 1]] - _map[s[i]];
    //             i = i + 1;
    //             continue;
    //         }
    //         
    //         result += _map[s[i]];
    //     }
    //     
    //     return result;
    // }
    //
    // private bool IsSubtractCase(char char1, char char2)
    // {
    //     if(char1 == 'I' && (char2 == 'V' || char2 == 'X'))
    //         return true;
    //     
    //     if(char1 == 'X' && (char2 == 'L' || char2 == 'C'))
    //         return true;
    //     
    //     if(char1 == 'C' && (char2 == 'D' || char2 == 'M'))
    //         return true;
    //     
    //     return false;
    // }
}