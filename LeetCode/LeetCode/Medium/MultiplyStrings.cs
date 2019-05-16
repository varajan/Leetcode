using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public class MultiplyStrings
    {
        private readonly Dictionary<char, string> _memory = new Dictionary<char, string>();

        public string Multiply(string num1, string num2)
        {
            var result = "";
            var i = "";

            if (num1.Length < num2.Length)
            {
                var t = num1;
                num1 = num2;
                num2 = t;
            }

            for (var j = num1.Length-1; j >= 0; j--)
            {
                string multiply;
                var key = num1[j];
                if (_memory.ContainsKey(key))
                {
                    multiply = _memory[key];
                }
                else
                {
                    multiply = Multiply(num2, num1[j]);
                    _memory.Add(key, multiply);
                }

                result = Add(result, multiply + i);
                i += "0";
            }

            return Trim(result);
        }

        private static string Trim(string number)
        {
            var result = "";
            var begin = true;

            foreach (var x in number)
            {
                if (begin && x == '0') continue;

                begin = false;
                result += x;
            }

            return result.Length > 0 ? result : "0";
        }

        private string Multiply(string number, char x)
        {
            if (x == '0') return "0";

            var result = "";
            var i ="";

            for (int j = number.Length-1; j >= 0; j--)
            {
                result = Add(result, Multiply(x, number[j]) + i);
                i += "0";
            }

            return result;
        }

        private static string Add(string x, string y)
        {
            var result = "";
            var offset = 0;

            for (int i = 0; i < Math.Max(x.Length, y.Length); i++)
            {
                var xIndex = x.Length - i;
                var xi = xIndex > 0 ? x[xIndex-1] : '0';

                var yIndex = y.Length - i;
                var yi = yIndex > 0 ? y[yIndex-1] : '0';

                var sum = xi + yi - 96 + offset;

                result = (sum % 10) + result;
                offset = sum / 10;
            }

            if (offset > 0) result = offset + result;

            return result;
        }

        private static int Multiply(char x, char y) => (x - 48) * (y - 48);
    }
}