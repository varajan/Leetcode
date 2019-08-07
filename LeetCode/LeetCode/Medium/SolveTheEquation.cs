using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class SolveTheEquation
    {
        public string SolveEquation(string equation)
        {
            var parts = GetParts(equation);
            var x = Sum(parts.Where(i => i.Contains('x')).ToList(), "x");
            var y = Sum(parts.Where(i => !i.Contains('x')).ToList());

            var resultX = int.Parse(GetMultiplier(x));
            var resultY = int.Parse(y) * -1;

            if (resultX == 0 && resultY == 0) return "Infinite solutions";
            if (resultX == 0) return "No solution";

            return $"x={resultY / resultX}";
        }

        private string Sum(List<string> elements, string x = "")
        {
            if (x != "") elements = elements.Select(GetMultiplier).ToList();

            var result = 0;

            elements.ForEach(i => result += int.Parse(i));

            return $"{result}{x}";
        }

        private string GetMultiplier(string x)
        {
            if (x == "x") return "1";
            if (x == "-x") return "-1";

            return x.Replace("x", string.Empty);
        }

        List<string> GetParts(string equation)
        {
            var result = new List<string>();

            var part = string.Empty;
            var negative = false;

            foreach (var x in equation)
            {
                if (x == '=') {
                    negative = true;
                    result.Add(part);
                    part = "-";
                    continue;
                }

                if ((x == '+' || x == '-') && part != "-")
                {
                    result.Add(part);
                    part = !negative && x == '-' || negative && x =='+' ? "-" : "";
                    continue;
                }

                part += x.ToString();
                part = part.Replace("--", "");
            }

            result.Add(part);

            return result.Where(i => !string.IsNullOrEmpty(i)).ToList();
        }
    }
}