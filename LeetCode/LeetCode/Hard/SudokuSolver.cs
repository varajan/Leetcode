using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LeetCode.Hard
{
    public class SudokuSolver
    {
        public char[][] SolveSudoku(char[][] board) => Solve(board);

        private char[][] Solve(char[][] test)
            {
                Dictionary<Point, List<char>> options;
                List<KeyValuePair<Point, List<char>>> singleOptions;

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

                    if (!test.Any(row => row.Any(x => x == '.'))) return test;
                    }
                } while (singleOptions.Any());

                var sortedOption = options.OrderBy(x => x.Value.Count).FirstOrDefault();
                if (sortedOption.Value != null)
                {
                    foreach (var x in sortedOption.Value)
                    {
                        if (test == null) return null;

                        var matrix = test.Select(row => row.ToArray()).ToArray();
                        matrix[sortedOption.Key.X][sortedOption.Key.Y] = x;

                        if (!IsValidSudoku(matrix)) continue;

                        var solution = Solve(matrix);
                        if (solution != null) return solution;
                    }
                }

            return null;
            }

        private Dictionary<Point, List<char>> GetOptions(char[][] test)
        {
        var options = new Dictionary<Point, List<char>>();
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (test[row][column] != '.') continue;

                    var point = new Point {X = row, Y = column};
                    options.Add(point, new List<char>());

                    for (char i = '1'; i <= '9'; i++)
                    {
                        if (IsValidNumber(test, point, i)) options[point].Add(i);
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
                        var iOptions = options.Where(x =>
                                x.Value.Contains(i) &&
                                blockX0 <= x.Key.X && x.Key.X <= blockX2 &&
                                blockY0 <= x.Key.Y && x.Key.Y <= blockY2)
                            .ToList();

                        var rows = iOptions.Select(x => x.Key.X).Distinct().ToList();
                        var cols = iOptions.Select(y => y.Key.Y).Distinct().ToList();

                        if (rows.Count == 1)
                        {
                            optimized = optimized || OptimizeHorizontal(blockX0, blockX2, blockY0, blockY2, i);
                        }
                        if (cols.Count == 1)
                        {
                            optimized = optimized || OptimizeVertical(blockX0, blockX2, blockY0, blockY2, i);
                        }
                    }
                }
            } while (optimized);

            return options;

            bool OptimizeHorizontal(int xMin, int xMax, int yMin, int yMax, char x)
            {
                bool result = false;

                for (int column = 0; column < 9; column++)
                {
                    if (yMin <= column && column <= yMax) continue;

                    for (int row = xMin; row <= xMax; row++)
                    {
                        var point = new Point { X = row, Y = column };
                        if (!options.ContainsKey(point)) continue;

                        result = result || options[point].Contains(x);
                        options[point].Remove(x);
                    }
                }

                return result;
            }

            bool OptimizeVertical(int xMin, int xMax, int yMin, int yMax, char x)
            {
                bool result = false;

                for (int row = 0; row < 9; row++)
                {
                    if (xMin <= row && row <= xMax) continue;

                    for (int column = yMin; column <= yMax; column++)
                    {
                        var point = new Point { X = row, Y = column };
                        if (!options.ContainsKey(point)) continue;

                        result = result || options[point].Contains(x);
                        options[point].Remove(x);
                    }
                }

                return result;
            }
        }

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
                    int x = (block / 3) * 3 + i / 3;
                    int y = (block % 3) * 3 + i % 3;

                    if (matrix[x][y] == '.') continue;
                    if (chars.Contains(matrix[x][y])) return false;

                    chars.Add(matrix[x][y]);
                }

                return true;
            }
        }
    }
}