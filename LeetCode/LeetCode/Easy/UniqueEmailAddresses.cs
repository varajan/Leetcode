using System.Linq;

namespace LeetCode.Easy
{
    class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            return emails.Select(Normalized).Distinct().Count();

            string Normalized(string mail)
            {
                var parts = mail.Split('@');

                return parts[0].Split('+')[0].Replace(".", "") + "@" + parts[1];
            }
        }
    }
}