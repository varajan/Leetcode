namespace LeetCode.Easy
{
    public static class Palindrome
    {
        public static bool Validate2(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            var step = 0;
            var length = s.Length;

            for (var i = 0; i < length / 2; i++)
            {
                if (s[i + step] != s[length - i - 1] && s[i] != s[length - step - i - 1])
                {
                    step++;
                    i--;
                }

                if (step > 1) return false;
            }

            return true;
        }
    }
}