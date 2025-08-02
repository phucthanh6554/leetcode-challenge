namespace Leetcode.Algorithm;

public class RotateImageProblem
{
    public void Rotate(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = i + 1; j < matrix[i].Length; j++)
            {
                Swap(ref matrix[i][j], ref matrix[j][i]);
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            ReverseArray(matrix[i]);
        }
    }

    private void Swap(ref int a, ref int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }

    private void ReverseArray(int[] arr)
    {
        for (var i = 0; i < arr.Length / 2; i++)
        {
            Swap(ref arr[i], ref arr[arr.Length - 1 - i]);
        }
    }
    
    // My first solution, this solution use array => we won't use it
    public void RotateFirst(int[][] matrix) {
        var nums = new int[matrix.Length * matrix.Length];
        var index = 0;
        
        for (var i = matrix.Length - 1; i >= 0; i--)
        {
            for (var j = 0; j < matrix.Length; j++)
            {
                nums[index++] = matrix[i][j];
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var x = i / matrix.Length;
            var y = i % matrix.Length;
            matrix[y][x] = nums[i];
        }
    }
}