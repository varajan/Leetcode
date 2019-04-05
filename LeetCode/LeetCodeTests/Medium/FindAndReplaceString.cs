using Replacer = LeetCode.Medium.FindAndReplaceString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class FindAndReplaceString
    {
        [Timeout(200)]
        [TestMethod]
        public void FindAndReplaceString_1() =>
            Assert.AreEqual("eeebffff",
                new Replacer().FindReplaceString("abcd", new []{0, 2}, new []{"a", "cd"}, new []{"eee", "ffff"}));

        [Timeout(200)]
        [TestMethod]
        public void FindAndReplaceString_2() =>
            Assert.AreEqual("aaqbqaqq",
                new Replacer().FindReplaceString("vyeqmeyggv", new []{4, 0, 7}, new []{ "mey", "vye", "ggv" }, new []{ "bq", "aa", "aqq" }));

        [Timeout(200)]
        [TestMethod]
        public void FindAndReplaceString_3()
        {
            var input = "zbvaqfnazkchqmvpahmxoizlnmxzmnzufimadagdvrowltqxxsdixucmsyloraesjdmbqdprmkcnovshpmvipmuksrfuxngxcbel";
            var indexes = new [] { 66, 71, 78, 14, 43, 19, 22, 26, 10, 12, 59, 8, 49, 80, 85, 97, 73, 88, 6, 4, 51, 83, 68, 2, 46, 36, 76, 30, 94, 56, 40, 34, 63 };
            var sources = new[] { "mb", "rm", "sh", "vpa", "wlt", "xo", "zl", "xz", "ch", "qm", "ora", "zk", "sd", "pm", "muk", "bel", "kcn", "srfux", "na", "qf", "ix", "ip", "qdp", "va", "qx", "dag", "ov", "zuf", "gx", "sy", "vro", "ma", "sjd" };
            var targets = new[] { "dp", "v", "xe", "tuo", "zc", "id", "mg", "m", "x", "t", "zo", "qtp", "bdj", "of", "lv", "dp", "eh", "tnira", "coz", "k", "ye", "h", "yamz", "dyr", "pa", "nv", "izz", "vgc", "e", "r", "cfb", "oto", "wli" };
            var output = "zbdyrkcozqtpxttuohmidimgnmmmnvgciotonvdcfbzcpaxbdjyeucmrlzoewlidpyamzvehizzxeofvhlvtniranecdp";

            Assert.AreEqual(output, new Replacer().FindReplaceString(input, indexes, sources, targets));
        }
    }
}