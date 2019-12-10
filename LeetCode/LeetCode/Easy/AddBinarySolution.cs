using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            string result = "";
            char offset = '0';

            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                var codes = new List<char>
                {
                    (a.Length - i > 0) ? a[a.Length - i -1] : '0',
                    (b.Length - i > 0) ? b[b.Length - i -1] : '0',
                    offset
                };

                var ones = codes.Where(c => c == '1').Count();
                offset = ones > 1 ? '1' : '0';

                result = (ones == 1 || ones == 3 ? '1' : '0') + result;
            }

            result = offset + result;

            while (result.Length> 1 && result[0] == '0')
            {
                result = result.Remove(0, 1);
            }

            return result;
        }
    }
}