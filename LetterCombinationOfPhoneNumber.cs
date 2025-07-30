namespace Leetcode.Algorithm;

public class LetterCombinationOfPhoneNumber
{
    private readonly Dictionary<char, string> _dic = new()
    { 
        ['1'] = "",
        ['2'] = "abc",
        ['3'] = "def",
        ['4'] = "ghi",
        ['5'] = "jkl",
        ['6'] = "mno",
        ['7'] = "pqrs",
        ['8'] = "tuv",
        ['9'] = "wxyz",
    };
    
    public IList<string> LetterCombinations(string digits) 
    {
        var result = new List<string>();
        
        //BackTrack(0, digits, string.Empty, result);

        return CombinationIterative(digits);
    }

    private IList<string> CombinationIterative(string digits)
    {
        var result = new List<string>();
        
        result.Add(string.Empty);

        foreach (var letter in digits)
        {
            var letters = _dic[letter];
            var temp = new List<string>();

            foreach (var t in result)
            {
                foreach (var c in letters)
                    temp.Add(t + c);
            }

            result = temp;
        }
        
        return result;
    }

    private void BackTrack(int index, string digits, string path, List<string> result)
    {
        if (path.Length == digits.Length)
        {
            result.Add(path);
            return;
        }
        
        var letters = _dic[digits[index]];

        foreach (var letter in letters)
        {
            BackTrack(index + 1, digits, path + letter, result);
        }
    }
}