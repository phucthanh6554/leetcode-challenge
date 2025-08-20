namespace Leetcode.Algorithm;

public class SetMatrixZerosProblem
{
    public void SetZeroes(int[][] matrix) 
    {
        var rowLength = matrix.Length;
        var colLength = matrix[0].Length;

        bool firstRowHasZero = false;
        bool firstColHasZero = false;

        // check first row
        for (var j = 0; j < colLength; j++)
            if (matrix[0][j] == 0) firstRowHasZero = true;

        // check first col
        for (var i = 0; i < rowLength; i++)
            if (matrix[i][0] == 0) firstColHasZero = true;

        // marker
        for (var i = 1; i < rowLength; i++)
        for (var j = 1; j < colLength; j++)
            if (matrix[i][j] == 0)
            {
                matrix[0][j] = 0;
                matrix[i][0] = 0;
            }

        // set rows
        for (var i = 1; i < rowLength; i++)
            if (matrix[i][0] == 0)
                for (var j = 1; j < colLength; j++)
                    matrix[i][j] = 0;

        // set cols
        for (var j = 1; j < colLength; j++)
            if (matrix[0][j] == 0)
                for (var i = 1; i < rowLength; i++)
                    matrix[i][j] = 0;

        // first row
        if (firstRowHasZero)
            for (var j = 0; j < colLength; j++) matrix[0][j] = 0;

        // first col
        if (firstColHasZero)
            for (var i = 0; i < rowLength; i++) matrix[i][0] = 0;
    }
}