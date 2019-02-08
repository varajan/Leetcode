using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    internal static class Extensions<T>
    {
        public static void ShouldEqual(List<List<T>> actual, List<List<T>> expected)
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

        public static void ShouldContainAll(List<List<T>> actual, List<List<T>> expected)
        {
            var message = string.Empty;

            if (actual.Count != expected.Count)
                message += $"Different count of rows. Expected: '{expected.Count}', actual: '{actual.Count}'.\n";

            foreach (var line in expected)
            {
                var i = FindRow(actual, line);

                if (i < 0)
                {
                    message += $"Line was not found: {AsString(line)}";
                }
                else
                {
                    actual.RemoveAt(i);
                }
            }
 
            if (!message.Equals(string.Empty))
            {
                Assert.Fail($"Not all expected rows were found:\n{message}");
            }
        }

        public static int FindRow(List<List<T>> list, List<T> line)
        {
            var target = AsString( line.OrderBy(x => x).ToList() );

            for (int i = 0; i < list.Count; i++)
            {
                var subLine = AsString( list[i].OrderBy(x => x).ToList() );

                if (target == subLine) return i;
            }

            return -1;
        }

        public static string Print(List<List<T>> list)
        {
            var result = string.Empty;

            foreach (var line in list)
            {
                result += $"new List<int> {{ {AsString(line)} }},";
            }

            return result;
        }

        public static string AsString(IList<T> list, string delimiter = ", ")
        {
            var result = string.Empty;

            for (var i = 0; i < list.Count - 1; i++)
            {
                result += list[i] + delimiter;
            }

            if (list.Count > 0)
            {
                result += list[list.Count - 1];
            }

            return result;
        }
    }
}