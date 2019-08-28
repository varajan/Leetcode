namespace LeetCode.Easy
{
    class FibonacciNumber
    {
        public int Fib(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;
            if (N == 2) return 1;

            return 2 * Fib(N - 2) + Fib(N - 3);
        }
    }
}