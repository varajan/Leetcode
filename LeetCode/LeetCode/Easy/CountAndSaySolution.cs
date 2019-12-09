using System.Linq;

namespace LeetCode.Easy
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var result = "1";

            for (var i = 1; i < n; i++)
            {
                result = CountAndSayR(result);
            }

            return result;
        }

        private string  CountAndSayR(string sequence)
        {
            var result = "";
            var count = 1;
            var symbol = sequence.First();

            for(var x = 1; x < sequence.Length; x++)
            {
                if (sequence[x] == symbol)
                {
                    count++;
                }
                else
                {
                    result += $"{count}{symbol}";
                    count = 1;
                    symbol = sequence[x];
                }
            }

            result += $"{count}{symbol}";

            return result;
        }
    }
}