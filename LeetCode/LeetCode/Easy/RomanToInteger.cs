using System.Linq;

namespace LeetCode.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            return s.Select((t, i) => (i + 1 < s.Length && GetInt(t) < GetInt(s[i + 1]) ? -GetInt(t) : GetInt(t))).Sum();
        }

        private static int GetInt(char roman)
        {
            var result = 0;

            switch (roman)
            {
                case 'I': result = 1;
                break;
                case 'V': result = 5;
                break;
                case 'X': result = 10;
                break;
                case 'L': result = 50;
                break;
                case 'C': result = 100;
                break;
                case 'D': result = 500;
                break;
                case 'M': result = 1000;
                break;
            }

            return result;
        }
    }
}