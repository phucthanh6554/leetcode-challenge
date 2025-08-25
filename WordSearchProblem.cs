namespace Leetcode.Algorithm;

public class WordSearchProblem
{
    
    public bool Exist(char[][] board, string word)
    {
        var rows = board.Length;
        var cols = board[0].Length;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                var result = Backtrack(board, word, 0, i, j);

                if (result)
                    return true;
            }
        }
        
        return false;
    }

    private bool Backtrack(char[][] board, string word, int index, int x, int y)
    {
        if(x < 0 || x >= board.Length || y < 0 || y >= board[0].Length || board[x][y] != word[index])
            return false;
        
        if(index == word.Length - 1)
            return true;

        var temp = board[x][y];
        board[x][y] = '@';

        var found = Backtrack(board, word, index + 1, x + 1, y) ||
               Backtrack(board, word, index + 1, x - 1, y) ||
               Backtrack(board, word, index + 1, x, y + 1) ||
               Backtrack(board, word, index + 1, x, y - 1);
        
        board[x][y] = temp;
        return found;
        
    }
}