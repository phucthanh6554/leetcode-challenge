namespace Leetcode.Algorithm;

public class PascalTriangleProblem
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var result = new List<IList<int>>();

        for (var i = 1; i <= numRows; i++)
        {
            var row = new List<int>(i);

            for (var j = 0; j < i; j++)
            {
                if (j == 0 || j == i - 1)
                {
                    row.Add(1);
                    continue;
                }
                
                row.Add(result[i - 2][j - 1] + result[i - 2][j]);
            }
            
            result.Add(row);
        }
        
        return result;
        
    }
}