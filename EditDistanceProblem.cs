namespace Leetcode.Algorithm;

public class EditDistanceProblem
{
    public int MinDistance(string word1, string word2)
    {
        var rows = word1.Length + 1;
        var cols = word2.Length + 1;

        var mapArr = new int[rows][];
        
        for(var i = 0; i < rows; i++)
            mapArr[i] = new int[cols];

        for (var i = 1; i < rows; i++)
            mapArr[i][0] = i;

        for (var i = 1; i < cols; i++)
            mapArr[0][i] = i;

        for (var i = 1; i < rows; i++)
        {
            for (var j = 1; j < cols; j++)
            {
                var minValue = Math.Min(mapArr[i - 1][j - 1], Math.Min(mapArr[i - 1][j], mapArr[i][j - 1]));
                if (word1[i - 1] == word2[j - 1])
                    mapArr[i][j] = minValue;
                else 
                    mapArr[i][j] = 1 + minValue;
            }
        }
        
        return mapArr[rows - 1][cols - 1];
    }
}