using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LeetCode.Hard
{
    public class SudokuSolver
    {
        public void SolveSudoku(in char[][] board)
        {
            Solve(board);
        }

        public char[][] Solve(in char[][] board)
        {
            Dictionary<Point, List<char>> options;
            List<KeyValuePair<Point, List<char>>> singleOptions;
            var test = board.Select(x => x.ToArray()).ToArray();

            do
            {
                options = GetOptions(test);
                singleOptions = options.Where(x => x.Value.Count == 1).ToList();

                if (!singleOptions.Any())
                {
                    options = OptimizedOptions(options);
                    singleOptions = options.Where(x => x.Value.Count == 1).ToList();
                }

                if (singleOptions.Any())
                {
                    singleOptions.ForEach(option => test[option.Key.X][option.Key.Y] = option.Value.First());

                    if (IsSudokuSolved(test)) return test;
                }
            } while (singleOptions.Any());

            var sortedOption = options.OrderBy(x => x.Value.Count).FirstOrDefault();

            foreach (var x in sortedOption.Value ?? new List<char>())
            {
                var matrix = test.Select(row => row.ToArray()).ToArray();
                matrix[sortedOption.Key.X][sortedOption.Key.Y] = x;

                if (!IsValidSudoku(matrix)) continue;

                var solution = Solve(matrix);
                if (solution != null) return solution;
            }

            return null;
        }

        private Dictionary<Point, List<char>> GetOptions(in char[][] test)
        {
            var options = new Dictionary<Point, List<char>>();

            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (test[row][column] == '.')
                    {
                        var point = new Point { X = row, Y = column };

                        for (char x = '1'; x <= '9'; x++)
                        {
                            if (IsValidNumber(test, point, x))
                            {
                                if (options.ContainsKey(point))
                                {
                                    options[point].Add(x);
                                }
                                else
                                {
                                    options.Add(point, new List<char> { x });
                                }
                            }
                        }
                    }
                }
            }

            return options;
        }

        private Dictionary<Point, List<char>> OptimizedOptions(Dictionary<Point, List<char>> options)
        {
            bool optimized;

            do
            {
                optimized = false;

                for (int block = 0; block < 9; block++)
                {
                    var blockX0 = (block / 3) * 3 + 0;
                    var blockX2 = (block / 3) * 3 + 2;
                    var blockY0 = (block % 3) * 3 + 0;
                    var blockY2 = (block % 3) * 3 + 2;

                    for (char i = '1'; i <= '9'; i++)
                    {
                        var iOptions = options
                            .Where(x => x.Value.Contains(i))
                            .Where(x => blockX0 <= x.Key.X && x.Key.X <= blockX2)
                            .Where(x => blockY0 <= x.Key.Y && x.Key.Y <= blockY2)
                            .ToList();

                        var rows = iOptions.Select(x => x.Key.X).Distinct().ToList();
                        var cols = iOptions.Select(y => y.Key.Y).Distinct().ToList();

                        if (rows.Count == 1)
                        {
                            for (int column = 0; column < 9; column++)
                            {
                                if (blockY0 <= column && column <= blockY2) continue;

                                for (int row = blockX0; row <= blockX2; row++)
                                {
                                    var point = new Point { X = row, Y = column };
                                    if (!options.ContainsKey(point)) continue;

                                    optimized = optimized || options[point].Contains(i);
                                    options[point].Remove(i);
                                }
                            }
                        }

                        if (cols.Count == 1)
                        {
                            for (int row = 0; row < 9; row++)
                            {
                                if (blockX0 <= row && row <= blockX2) continue;

                                for (int column = blockY0; column <= blockY2; column++)
                                {
                                    var point = new Point { X = row, Y = column };
                                    if (!options.ContainsKey(point)) continue;

                                    optimized = optimized || options[point].Contains(i);
                                    options[point].Remove(i);
                                }
                            }
                        }
                    }
                }
            } while (optimized);

            return options;
        }

        private bool IsSudokuSolved(in char[][] test) => !test.Any(row => row.Any(x => x == '.'));

        private bool IsValidNumber(in char[][] test, Point point, char x)
        {
            var matrix = test.Select(a => a.ToArray()).ToArray();
            matrix[point.X][point.Y] = x;

            return IsValidSudoku(matrix);
        }

        private bool IsValidSudoku(in char[][] test)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!IsRowValid(test, i)) return false;
                if (!IsColumnValid(test, i)) return false;
                if (!IsBlockValid(test, i)) return false;
            }

            return true;

            bool IsRowValid(in char[][] matrix, int row)
            {
                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    if (matrix[row][i] == '.') continue;
                    if (chars.Contains(matrix[row][i])) return false;

                    chars.Add(matrix[row][i]);
                }

                return true;
            }

            bool IsColumnValid(in char[][] matrix, int column)
            {
                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    if (matrix[i][column] == '.') continue;
                    if (chars.Contains(matrix[i][column])) return false;

                    chars.Add(matrix[i][column]);
                }

                return true;
            }

            bool IsBlockValid(in char[][] matrix, int block)
            {
                var chars = new HashSet<int>();

                for (int i = 0; i < 9; i++)
                {
                    int x = GetBlockX(block, i);
                    int y = GetBlockY(block, i);

                    if (matrix[x][y] == '.') continue;
                    if (chars.Contains(matrix[x][y])) return false;

                    chars.Add(matrix[x][y]);
                }

                return true;

            }
        }

        private int GetBlockX(int block, int i) => (block / 3) * 3 + i / 3;

        private int GetBlockY(int block, int i) => (block % 3) * 3 + i % 3;
    }
}