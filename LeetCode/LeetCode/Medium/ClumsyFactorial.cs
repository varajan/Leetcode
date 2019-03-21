namespace LeetCode.Medium
{
    public static class ClumsyFactorial
    {
        public static int Clumsy(int N)
        {
            var j = 0;
            var result = 0;
            var multipl = N;
            var added = false;
            for (var i = N - 1; i > 0; i--)
            {
                j++;

                if (j % 4 == 1) { multipl *= i; }
                if (j % 4 == 2) { multipl /= i; }
                if (j % 4 == 3) { result += multipl + i; added = true; }
                if (j % 4 == 0) { multipl = -i; added = false; }
            }

            result += added ? 0 : multipl;

            return result;
        }
    }
}