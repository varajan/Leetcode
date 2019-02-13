using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public static class Extensions
    {
        public static int Factorial(this int n)
        {
            var result = 1;

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        public static List<string> GenerateCombinations(this int n, int length)
        {
            var result = new List<string>();
            var combinations = GetCombinationCount(n, length);

            for (var row = 0; row < combinations; row++)
            {
                result.Add(string.Empty);
            }

            for (var column = 0; column < length; column++)
            {
                var rowsCount = RowsCount(column, length, n);
                var numbers = new Dictionary<int, int>();
                for (var number = 0; number < n; number++)
                {
                    numbers.Add(number, 0);
                }

                for (var row = 0; row < combinations; row++)
                {
                    for (var number = 0; number < n; number++)
                    {
                        if (result[row].Contains($"{number}"))
                        {
                            numbers[number] = numbers[number] + 1;
                            continue;
                        }

                        if (numbers[number] < rowsCount)
                        {
                            result[row] += $"{number}";
                            numbers[number] = numbers[number] + 1;
                            break;
                        }
                    }

                    if ((column > 0 && row < combinations - 1 && result[row][column - 1] != result[row + 1][column - 1])
                        || (numbers.All(record => record.Value >= rowsCount)))
                    {
                        for (var x = 0; x < n; x++)
                        {
                            numbers[x] = 0;
                        }
                    }
                }

                for (var x = 0; x < n; x++)
                {
                    numbers[x] = 0;
                }
            }

            return result;
        }

        private static int RowsCount(int column, int length, int n) =>
            n == length ? (length - column - 1).Factorial() : (length - column).Factorial();

        private static int GetCombinationCount(int n, int length) => n.Factorial() / (n - length).Factorial();
    }
}
