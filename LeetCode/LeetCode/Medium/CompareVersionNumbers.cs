using System;

namespace LeetCode.Medium
{
    public static class CompareVersionNumbers
    {
        public static int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');

            var vAsInt1 = 1;
            var vAsInt2 = 1;

            for (int i = 1; i <= Math.Max(v1.Length, v2.Length); i++)
            {
                vAsInt1 *= 10;
                vAsInt2 *= 10;

                if (v1.Length >= i) vAsInt1 += int.Parse(v1[i - 1]);
                if (v2.Length >= i) vAsInt2 += int.Parse(v2[i - 1]);
            }

            if (vAsInt1 == vAsInt2) return 0;

            return vAsInt1 > vAsInt2 ? 1 : -1;
        }
    }
}