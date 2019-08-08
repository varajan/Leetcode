namespace LeetCode.Medium
{
    public class CountNumbersWithUniqueDigits
    {
        public int Count(int n)
        {
            int result = 1;

            for (int i = 10; i > 10-n; i--) result *= i;

            for (int i = 1; i <= n - 1; i++)
            {
                var x = 1;
                for (int j = 9; j > 10-i; j--) x *= j;

                result += x * i;
            }

            return result;
        }
    }
}