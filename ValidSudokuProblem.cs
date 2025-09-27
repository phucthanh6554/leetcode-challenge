namespace Leetcode.Algorithm
{
    public class ValidSudokuProblem
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = new int[9];
            var columns = new int[9];
            var blocks = new int[9];

            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    var num = board[i][j] - '0';
                    var bit = 1;

                    if ((rows[i] & (bit << num)) != 0)
                        return false;

                    if ((columns[j] & (bit << num)) != 0)
                        return false;

                    var blockIndex = (i / 3) * 3 + (j / 3);

                    if ((blocks[blockIndex] & (bit << num)) != 0)
                        return false;

                    rows[i] = rows[i] | (bit << num);
                    columns[j] = columns[j] | (bit << num);
                    blocks[blockIndex] = blocks[blockIndex] | (bit << num);
                }
            }

            return true;
        }
    }
}
