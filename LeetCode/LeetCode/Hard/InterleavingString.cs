namespace LeetCode.Hard
{
    public class InterleavingString
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            return IsInterleaved();

            bool IsInterleaved(int i1 = 0, int i2 = 0, int i = 0)
            {
                for (; i < s3.Length; i++)
                {
                    if (i1 < s1.Length && i2 < s2.Length && s1[i1] == s2[i2] && s1[i1] == s3[i])
                    {
                        i++;

                        return IsInterleaved(i1, i2 + 1, i) ||
                               IsInterleaved(i1 + 1, i2, i);
                    }

                    if (i1 < s1.Length && s3[i] == s1[i1])
                    {
                        i1++;
                        continue;
                    }

                    if (i2 < s2.Length && s3[i] == s2[i2])
                    {
                        i2++;
                        continue;
                    }

                    return false;
                }

                return s1.Length == i1 && s2.Length == i2;
            }
       }
    }
}