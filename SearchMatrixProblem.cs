namespace Leetcode.Algorithm;

public class SearchMatrixProblem
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        // check null or empty matrix
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return false;
        
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        
        // if target is less than the first element or greater than the last element
        if(target < matrix[0][0] || target > matrix[rows - 1][cols - 1])
            return false;
        
        // find row index
        var min = 0;
        var max = matrix.Length - 1;

        var rowIndex = -1;

        while (min <=max)
        {
            rowIndex = (max + min) / 2;

            if (matrix[rowIndex][0] == target)
                return true;

            if (target > matrix[rowIndex][0])
                min = rowIndex + 1;
            else
                max = rowIndex - 1;
        }

        if (matrix[rowIndex][0] > target)
            rowIndex -= 1;

        min = 0;
        max = matrix[0].Length - 1;

        while (min <= max)
        {
            var mid = (min + max) / 2;
            
            if(matrix[rowIndex][mid] == target)
                return true;
            
            if(target > matrix[rowIndex][mid])
                min = mid + 1;
            else
                max = mid - 1;
        }

        return false;
    }
    
    
}