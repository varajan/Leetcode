using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public class MultiplyStrings
    {
        private Dictionary<char, string> Memory = new Dictionary<char, string>();

        public string Multiply(string num1, string num2)
        {
            string result = "";
            var i = "";

            if (num1.Length < num2.Length)
            {
                var t = num1;
                num1 = num2;
                num2 = t;
            }

            for (int j = num1.Length-1; j >= 0; j--)
            {
                string multipy;
                var key = num1[j];
                if (Memory.ContainsKey(key))
                {
                    multipy = Memory[key];
                }
                else
                {
                    multipy = Myltiply(num2, num1[j]);
                    Memory.Add(key, multipy);
                }

                result = Add(result, multipy + i);
                i += "0";
            }

            return Trim(result);
        }

        private string Trim(string number)
        {
            var result = "";
            var begin = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (begin && number[i] == '0') continue;

                begin = false;
                result += number[i];
            }

            return result.Length > 0 ? result : "0";
        }

        private string Myltiply(string number, char x)
        {
            if (x == '0') return "0";

            string result = "";
            var i ="";

            for (int j = number.Length-1; j >= 0; j--)
            {
                result = Add(result, Multipy(x, number[j]) + i);
                i += "0";
            }

            return result;
        }

        private string Add(string x, string y)
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

        private int Multipy(char x, char y) => (x - 48) * (y - 48);
    }
}