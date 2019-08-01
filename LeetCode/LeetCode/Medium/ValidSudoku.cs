using System.Collections.Generic;

namespace LeetCode.Medium
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!IsRowValid(i))    return false;
                if (!IsColumnValid(i)) return false;
                if (!IsRectValid(i))   return false;
            }

            return true;

            bool IsRowValid(int row)
            {
                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    if (board[row][i] == '.') continue;
                    if (chars.Contains(board[row][i])) return false;

                    chars.Add(board[row][i]);
                }

                return true;
            }

            bool IsColumnValid(int column)
            {
                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    if (board[i][column] == '.') continue;
                    if (chars.Contains(board[i][column])) return false;

                    chars.Add(board[i][column]);
                }

                return true;
            }

            bool IsRectValid(int rectangle)
            {
                // 0 1 2
                // 3 4 5
                // 6 7 8

                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    int x = getX(i);
                    int y = getY(i);

                    if (board[x][y] == '.') continue;
                    if (chars.Contains(board[x][y])) return false;

                    chars.Add(board[x][y]);
                }

                return true;

                int getX(int i) => (rectangle / 3)*3 + i / 3;

                int getY(int i) => (rectangle % 3)*3 + i % 3;
            }
        }
    }
}