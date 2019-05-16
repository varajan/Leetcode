namespace LeetCode.Hard
{
    public class IntegerToEnglishWords
    {
        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";

            var result = string.Empty;
            var blocks = new[] { "", "Thousand", "Million", "Billion" };

            for (var block = 0; block < blocks.Length && num > 0; block++)
            {
                var parsedBlock = ParseBlock(num % 1000);

                if (!string.IsNullOrEmpty(parsedBlock))
                {
                    result = $"{parsedBlock} {blocks[block]} " + result;
                }

                num /= 1000;
            }

            return result.Trim();
        }

        private string ParseBlock(int number) => $"{Hundreds(number)} {TwoDigits(number)}".Trim();

        private string OneDigit(int number)
        {
            switch (number)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";

                default: return string.Empty;
            }
        }

        private string Hundreds(int number)
        {
            var hundreds = number / 100;

            switch (hundreds)
            {
                case 0: return string.Empty;
                case 1: return "One Hundred";
                default: return $"{OneDigit(hundreds)} Hundred";
            }
        }

        private string TwoDigits(int number)
        {
            number %= 100;

            switch (number)
            {
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";

                default: return $"{SecondDigit(number / 10)} {OneDigit(number % 10)}".Trim();
            }
        }

        private string SecondDigit(int number)
        {
            switch (number)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";

                default: return string.Empty;
            }
        }
    }
}