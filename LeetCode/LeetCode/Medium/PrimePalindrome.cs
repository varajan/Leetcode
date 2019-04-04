using System;

namespace LeetCode.Medium
{
    public static class PrimePalindrome
    {
        public static int GetPrimePalindrome(int N)
        {
            if (!IsPalindrome(N)) N = Next(N);

            while (!IsPrime(N))
            {
                N = Next(N);
            }

            return N;
        }

        private static int Next(int n)
        {
            if (All9(n)) return n + 2;
            if (n < 11) return ++n;
            var nn = n.ToString();
            var len = nn.Length;

            return len % 2 == 0 ? NextOdd(n, len) : NextNotOdd(n, len, nn);
        }

        private static bool All9(int n)
        {
            while (n > 0)
            {
                if (n % 10 != 9) return false;
                n /= 10;
            }

            return true;
        }

        private static int NextNotOdd(int n, int len, string nn)
        {
            var half = (len - 1) / 2;
            var pow = (int) Math.Pow(10, half);
            var begin = len > 1 ? n / pow / 10 : 0;
            var middle = nn[half] - 47;

            if (middle == 10)
            {
                middle = 0;
                begin++;
            }

            if (begin > 0)
            {
                var result = begin;
                result *= 10;
                result += middle;
                result *= pow;
                result += Reverse(begin);

                return result;
            }

            return middle;
        }

        private static int NextOdd(int n, int len)
        {
            var half = len / 2;
            var pow = (int) Math.Pow(10, half);
            var begin = n / pow + 1;

            return begin * pow + Reverse(begin);
        }

        private static int Reverse(int number)
        {
            var result = 0;

            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        private static bool IsPrime(int n)
        {
            if (n <= 3) return n > 1;
            if (n % 2 == 0 || n % 3 == 0) return false;

            var i = 5;
            while (i * i <= n)
            {
                if (n % i ==0 || n % (i+2)==0)
                return false;

                i += 6;
            }
            return true;
        }

        private static bool IsPalindrome(int n)
        {
            var nn = n.ToString();
            var len = nn.Length;
            for (int i = 0; i < len / 2; i++)
                if (nn[i] != nn[len - i - 1]) return false;

            return true;
        }
    }
}
