using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Medium
{
    public static class ValidateIpAddress
    {
        public static string ValidateAddress(string IP)
        {
            var v4 = "[0-9]{1,3}";
            var v6 = "[0-9a-fA-F]{1,4}";
            var ipv4 = $"^{v4}.{v4}.{v4}.{v4}$";
            var ipv6 = $"^{v6}:{v6}:{v6}:{v6}:{v6}:{v6}:{v6}:{v6}$";

            if (Regex.IsMatch(IP, ipv6)) return "IPv6";
            if (Regex.IsMatch(IP, ipv4)
                && IP.Split('.').All(x => x == "0" || !x.StartsWith("0") && int.Parse(x) < 256))
                return "IPv4";

            return "Neither";
        }
    }
}