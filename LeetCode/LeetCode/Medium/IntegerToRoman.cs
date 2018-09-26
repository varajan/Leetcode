using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var replaces = new List<List<string>>
            {
                new List<string> {"DCCCC", "CM"},
                new List<string> {"CCCC", "CD"},
                new List<string> {"LXXXX", "XC"},
                new List<string> {"XXXX", "XL"},
                new List<string> {"VIIII", "IX"},
                new List<string> {"IIII", "IV"}
            };

            var result = "";

            foreach (var x in new [] {'M', 'D', 'C', 'L', 'X', 'V', 'I'})
            {
                while (num >= GetInt(x))
                {
                    result += x;
                    num -= GetInt(x);
                }
            }

            foreach (var replace in replaces)
            {
                result = result.Replace(replace.First(), replace.Last());
            }

            return result;
        }

        private static int GetInt(char roman)
        {
            var result = 0;

            switch (roman)
            {
                case 'I':
                    result = 1;
                    break;
                case 'V':
                    result = 5;
                    break;
                case 'X':
                    result = 10;
                    break;
                case 'L':
                    result = 50;
                    break;
                case 'C':
                    result = 100;
                    break;
                case 'D':
                    result = 500;
                    break;
                case 'M':
                    result = 1000;
                    break;
            }

            return result;
        }
    }
}