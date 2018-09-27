using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    internal static class Extensions<T>
    {
        public static void ShouldEqual(List<List<T>> expected, List<List<T>> actual)
        {
            var message = string.Empty;

            if (actual.Count != expected.Count)
                message += $"Different count of rows. Expected: '{expected.Count}', actual: '{actual.Count}'.\n";

            for (var i = 0; i < Math.Min(actual.Count, expected.Count); i++)
            {
                if (actual[i].Count != expected[i].Count)
                    message += $"Rows have different count of elements at row '{i}'. Expected: '{expected[i].Count}', actual: '{actual[i].Count}'.\n";

                for (var j = 0; j < Math.Min(actual[i].Count, expected[i].Count); j++)
                {
                    if (!expected[i][j].Equals("?") && actual[i][j].ToString() != expected[i][j].ToString())
                        message += $"Different values at row '{i}', position '{j}'. Expected: '{expected[i][j]}', actual: '{actual[i][j]}'.\n";
                }
            }

            if (!message.Equals(string.Empty))
            {
                Assert.Fail($"Rows are different:\n{message}");
            }
        }
    }
}