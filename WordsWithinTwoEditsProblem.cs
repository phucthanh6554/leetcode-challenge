namespace Leetcode.Algorithm;

public class WordsWithinTwoEditsProblem
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary)
    {
        var result = new List<string>(queries.Length);
        
        foreach (var word in queries)
        {
            foreach (var dictionaryWord in dictionary)
            {
                var diff = 0;

                for (var i = 0; i < word.Length; i++)
                {
                    if(word[i] != dictionaryWord[i])
                        diff++;
                    
                    if(diff > 2)
                        break;
                }

                if (diff <= 2)
                {
                    result.Add(word);
                    break;
                }
            }
        }
        
        return result;
    }
}