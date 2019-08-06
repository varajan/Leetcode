namespace LeetCode.Medium
{
    class StringWithoutAAAorBBB
    {
        public string StrWithout3a3b(int A, int B)
        {
            string result = "";

            while (A > 0 || B > 0)
            {
                if (A > B && !result.EndsWith("aa") || result.EndsWith("bb"))
                {
                    A--;
                    result += "a";
                }
                else
                {
                    B--;
                    result += "b";
                }
            }

            return result;
        }
    }
}