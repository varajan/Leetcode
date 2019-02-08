namespace LeetCode.Medium
{
    public static class StringToInt_ATOI
    {
        public static int MyAtoi(string str)
        {
            str = str.Trim() + "+";
            bool negative = false;

            var number = "0";

            for (var i = 0; i < str.Length; i++)
            {
                if (i == 0 && (str[0] == '-' || str[0] == '+'))
                {
                    negative = (str[0] == '-');
                    continue;
                }

                if (char.IsDigit(str[i]))
                {
                    number += str[i];
                }
                else break;
            }

            var result = double.Parse(number) * (negative ? -1 : 1);

            if (result > int.MaxValue) return int.MaxValue;
            if (result < int.MinValue) return int.MinValue;

            return (int)result;
        }
    }
}
