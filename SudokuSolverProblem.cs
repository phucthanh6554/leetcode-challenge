namespace Leetcode.Algorithm
{
    public class SudokuSolverProblem
    {
        private readonly int[] _rows = new int[9];
        private readonly int[] _columns = new int[9];
        private readonly int[] _blocks = new int[9];

        public void SolveSudoku(char[][] board)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(board[i][j] != '.')
                        TurnOn(i, j, board[i][j]);
                }
            }

            BackTrack(board);
        }

        private bool BackTrack(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (var c = '1'; c <= '9'; c++)
                        {
                            if (Validate(board, i, j, c))
                            {
                                board[i][j] = c;

                                TurnOn(i, j, c);

                                if (BackTrack(board))
                                    return true;

                                board[i][j] = '.';
                                TurnOff(i, j, c);
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private void TurnOn(int row, int col, char c)
        {
            var num = c - '1';
            var bit = 1;

            _rows[row] = _rows[row] | (bit << num);
            _columns[col] = _columns[col] | (bit << num);

            var blockIndex = (row / 3) * 3 + (col / 3);
            _blocks[blockIndex] = _blocks[blockIndex] | (bit << num);
        }

        private void TurnOff(int row, int col, char c)
        {
            var num = c - '1';
            var bit = ~(1 << num);

            _rows[row] = _rows[row] & bit;
            _columns[col] = _columns[col] & bit;

            var blockIndex = (row / 3) * 3 + (col / 3);
            _blocks[blockIndex] = _blocks[blockIndex] & bit;
        }

        private bool Validate(char[][] board, int row, int col, char c)
        {
            var num = c - '1';
            var bit = 1;

            if ((_rows[row] & (bit << num)) != 0)
                return false;

            if ((_columns[col] & (bit << num)) != 0)
                return false;

            var blockIndex = (row / 3) * 3 + col / 3;

            if ((_blocks[blockIndex] & (bit << num)) != 0)
                return false;

            return true;
        }
    }
}
