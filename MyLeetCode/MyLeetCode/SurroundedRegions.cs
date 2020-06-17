namespace myleetcode
{
    public class SurroundedRegions
    {
        public void Solve(char[][] board)
        {
            if (board.Length == 0 || board[0].Length == 0)
                return;
            if (board.Length < 2 || board[0].Length < 2)
                return;
            int m = board.Length, n = board[0].Length;
            //Any 'O' connected to a boundary can't be turned to 'X', so ...
            //Start from first and last column, turn 'O' to '*'.
            for (int i = 0; i < m; i++)
            {
                if (board[i][0] == 'O')
                    BoundaryDFS(board, i, 0);
                if (board[i][n - 1] == 'O')
                    BoundaryDFS(board, i, n - 1);
            }
            //Start from first and last row, turn '0' to '*'
            for (int j = 0; j < n; j++)
            {
                if (board[0][j] == 'O')
                    BoundaryDFS(board, 0, j);
                if (board[m - 1][j] == 'O')
                    BoundaryDFS(board, m - 1, j);
            }
            //post-prcessing, turn 'O' to 'X', '*' back to 'O', keep 'X' intact.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                    else if (board[i][j] == '*')
                        board[i][j] = 'O';
                }
            }
        }

        //Use DFS algo to turn internal however boundary-connected 'O' to '*';
        private void BoundaryDFS(char[][] board, int i, int j)
        {
            if (i < 0 || i > board.Length - 1 || j < 0 || j > board[0].Length - 1)
                return;
            if (board[i][j] == 'O')
                board[i][j] = '*';
            if (i > 1 && board[i - 1][j] == 'O')
                BoundaryDFS(board, i - 1, j);
            if (i < board.Length - 2 && board[i + 1][j] == 'O')
                BoundaryDFS(board, i + 1, j);
            if (j > 1 && board[i][j - 1] == 'O')
                BoundaryDFS(board, i, j - 1);
            if (j < board[i].Length - 2 && board[i][j + 1] == 'O')
                BoundaryDFS(board, i, j + 1);
        }
    }

}