using System.Linq;

namespace LeetCode.Medium
{
    public class MaskingPersonalInformation
    {
        public string MaskPII(string S)
        {
            return S.Contains('@') ? GetEmailAnonymized() : GetPhoneAnonymized();

            string GetEmailAnonymized()
            {
                S = S.ToLower();
                var first = S.First();
                var last = S.Split('@')[0].Last();
                var domain = S.Split('@').Last();

                return $"{first}*****{last}@{domain}";
            }

            string GetPhoneAnonymized()
            {
                var phone = "";
                var result = "";

                foreach (var c in S)
                {
                    if (char.IsDigit(c)) phone += $"{c}";
                }

                for (int i = 0; i < phone.Length; i++)
                {
                    result += i < phone.Length - 4 ? "*" : phone[i].ToString();
                }

                if (result.Length > 10) result = "+" + result;

                for (var i = 1; i < 4 && result.Length - 4 * i > 0; i++)
                {
                    result = result.Insert(result.Length - 4 * i, "-");
                }

                return result;
            }
        }
    }
}