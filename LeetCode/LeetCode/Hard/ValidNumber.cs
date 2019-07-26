using System.Text.RegularExpressions;

namespace LeetCode.Hard
{
    public class ValidNumber
    {
        public bool IsNumber(string s) =>
            !Regex.IsMatch(s.Trim(), @"^[+-]?(\.|\s*|(\.?e.+))$") &&
             Regex.IsMatch(s.Trim(), @"^[+-]?\d*\.?\d*(e[+-]?\d+)?$");
    }
}