namespace LeetCode.Easy
{
    public class CompressSolution
    {
        public int Compress(char[] chars)
        {
            int result = 0;
            var count = 1;
            var symbol = chars[0];

            for(var i = 1; i < chars.Length; i++)
            {
                if (chars[i] == symbol) { count++; }
                else
                {
                    AdustArray();

                    count = 1;
                    symbol = chars[i];
                }
            }

            AdustArray();

            return result;

            // ---------------------------------------------------------
            void AdustArray()
            {
                chars[result] = symbol;
                result++;

                if (count > 1)
                {
                    if (count > 9) { chars[result++] = (char)(count / 10 + 48); count %= 10; }
                    chars[result++] = (char)(count + 48);
                }
            }
            // ---------------------------------------------------------
        }
    }
}